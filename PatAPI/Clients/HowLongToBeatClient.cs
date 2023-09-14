using Infrastructure.Constants;
using SAM.Models.HLTB;
using System.Text.Json;
using System.Text;
using Infrastructure.Models.HTLB;

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

            return await client.GetFromJsonAsync<SingleGameResponse>(string.Format(HowLongToBeatConstants.ApiSingleGameFormattablePath, gameId)); //TODO: fix Json Objects

        }
    }
}
