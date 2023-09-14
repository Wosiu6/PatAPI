using Infrastructure.Models.Exceptions;
using Infrastructure.Models.HTLB;
using PatAPI.Clients;
using SAM.Models.HLTB;

namespace PatAPI.Services
{
    public class HowLongToBeatService : IHowLongToBeatService
    {
        private readonly HowLongToBeatClient _client;

        public HowLongToBeatService(IHttpClientFactory httpClientFactory)
        {
            _client = new HowLongToBeatClient(httpClientFactory);
        }

        public async Task<SingleGameResponse?> GetGameById(string gameId)
        {
            return await _client.GetGameById(gameId);
        }

        public async Task<GamesSearchResponse?> SearchGamesByName(string gameName)
        {
            return await _client.SearchGamesByName(gameName);
        }

        public async Task<GameSearchResponse?> GetGameByName(string gameName)
        {
            GamesSearchResponse? games = await _client.SearchGamesByName(gameName);

            if (games is not null)
            {
                GameSearchResponse? gameSearchResponse = games.GameSearchResponse?.FirstOrDefault();

                if (gameSearchResponse is not null)
                {
                    return gameSearchResponse;
                }
                else
                {
                    throw new GameNotFoundExcpetion();
                }
            }
            else
            {
                throw new GameNotFoundExcpetion();
            }
        }
    }
}
