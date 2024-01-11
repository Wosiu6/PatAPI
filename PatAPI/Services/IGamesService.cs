using PatAPI.Infrastructure.Models.HLTB;
using PatAPI.Infrastructure.Models.HLTB._next;

namespace PatAPI.Services
{
    public interface IGamesService
    {
        public abstract Task<Game?> GetLibraryGame(int gameName);
        public abstract Task<SingleGameResponse?> GetGameById(string gameName);
        public abstract Task<GamesSearchResponse?> SearchGamesByName(string gameName);
        public abstract Task<string?> GetBuildId();
    }
}
