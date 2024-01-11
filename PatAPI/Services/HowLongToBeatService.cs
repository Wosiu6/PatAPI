using Microsoft.Extensions.Caching.Memory;
using PatAPI.Clients;
using PatAPI.Infrastructure.Exceptions;
using PatAPI.Infrastructure.Models.HLTB;
using PatAPI.Infrastructure.Models.HLTB._next;

namespace PatAPI.Services
{
    public class HowLongToBeatService : IHowLongToBeatService
    {
        private readonly HowLongToBeatClient _client;
        private readonly IMemoryCache _cache;

        public HowLongToBeatService(IHttpClientFactory httpClientFactory, IMemoryCache cache)
        {
            _client = new HowLongToBeatClient(httpClientFactory);
            _cache = cache;
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

            if (games?.GameSearchResponse?.Count > 0)
            {
                return games.GameSearchResponse[0];
            }
            else
            {
                throw new GameNotFoundException();
            }
        }

        public async Task<string?> GetBuildId()
        {
            try
            {
                return await _client.GetBuildId();
            }
            catch
            {
                _cache.Remove("buildId");

                return await _client.GetBuildId();
            }
        }
    }
}
