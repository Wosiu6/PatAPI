using Infrastructure.Models.Exceptions;
using PatAPI.Clients;
using SAM.Game.HLTB;

namespace PatAPI.Services
{
    public class HowLongToBeatService : IHowLongToBeatService
    {
        private readonly HowLongToBeatClient _client;

        public HowLongToBeatService(IHttpClientFactory httpClientFactory)
        {
            _client = new HowLongToBeatClient(httpClientFactory);
        }

        public async Task<GamesSearchResponse?> FindGamesByName(string gameName)
        {
            return await _client.SearchGameByName(gameName);
        }

        public async Task<GameSearchResponse?> GetGameByName(string gameName)
        {
            GamesSearchResponse? games = await _client.SearchGameByName(gameName);

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
