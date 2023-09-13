using Infrastructure.Constants;
using SAM.Game.HLTB;
using System.Text.Json;
using System.Text;

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

        public async Task<GamesSearchResponse?> SearchGameByName(string gameName)
        {
            HttpClient client = _httpClientFactory.CreateClient(HowLongToBeatConstants.ClientName);

            StringContent content = GenerateStringContentFromGameName(gameName);

            HttpResponseMessage response = await client.PostAsync("api/search", content);
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
    }
}
