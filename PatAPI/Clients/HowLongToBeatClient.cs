using System.Text.Json;
using System.Text;
using PatAPI.Infrastructure.Constants;
using PatAPI.Infrastructure.Models.HLTB._next;
using PatAPI.Infrastructure.Models.HLTB;

namespace PatAPI.Clients
{
    public class HowLongToBeatClient : IHowLongToBeatClient
    {
        private const string JsonContentType = "application/json";

        private readonly IHttpClientFactory _httpClientFactory;

        public HowLongToBeatClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<GamesSearchResponse?> SearchGamesByName(string gameName)
        {
            HttpClient client = _httpClientFactory.CreateClient(HowLongToBeatConstants.ClientName);

            StringContent content = GenerateStringContentFromGameName(gameName);

            HttpResponseMessage response = await client.PostAsync(HowLongToBeatConstants.ApiSearchPath, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<GamesSearchResponse>();
        }

        private static StringContent GenerateStringContentFromGameName(string gameName)
        {
            List<string> searchTerms = gameName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                .Select(part => part.Trim())
                                                .ToList();

            var requestData = new { searchTerms };
            var jsonBody = JsonSerializer.Serialize(requestData);

            return new StringContent(jsonBody, Encoding.UTF8, JsonContentType);
        }

        public async Task<SingleGameResponse?> GetGameById(string gameId)
        {
            HttpClient client = _httpClientFactory.CreateClient(HowLongToBeatConstants.ClientName);

            string buildId = await GetBuildId();
            string url = string.Format(HowLongToBeatConstants.ApiSingleGameFormattablePath, buildId, gameId);

            return await client.GetFromJsonAsync<SingleGameResponse>(url);
        }

        public async Task<string> GetBuildId()
        {
            HttpClient client = _httpClientFactory.CreateClient(HowLongToBeatConstants.ClientName);

            string? response = await client.GetStringAsync(client.BaseAddress);

            string stringToFind = "buildId";

            int indexOfBuild = response.IndexOf(stringToFind);

            if (indexOfBuild != -1)
            {
                int startingIndex = response.IndexOf('"', indexOfBuild + stringToFind.Length + 1) + 1;
                int endingIndex = response.IndexOf('"', startingIndex + 1);

                if (startingIndex != -1 && endingIndex != -1)
                {
                    return response[startingIndex..endingIndex];
                }
            }

            throw new ("Build ID not found in the response.");
        }
    }
}
