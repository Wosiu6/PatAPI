using Infrastructure.Models.HLTB;
using Infrastructure.Models.HLTB._next;

namespace PatSite.Server.Services
{
    public interface IHowLongToBeatService
    {
        public abstract Task<GameSearchResponse?> GetGameByName(string gameName);
        public abstract Task<SingleGameResponse?> GetGameById(string gameName);
        public abstract Task<GamesSearchResponse?> SearchGamesByName(string gameName);
        public abstract Task<string?> GetBuildId();
    }
}
