using Infrastructure.Models.HLTB;

namespace PatSite.Server.Clients
{
    public interface IHowLongToBeatClient
    {
        //public abstract Task<SingleGameResponse?> GetGameById(string gameId);
        public abstract Task<GamesSearchResponse?> SearchGamesByName(string gameName);
    }
}