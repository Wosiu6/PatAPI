using PatAPI.Infrastructure.Models.HLTB;

namespace PatAPI.Clients
{
    public interface IHowLongToBeatClient
    {
        //public abstract Task<SingleGameResponse?> GetGameById(string gameId);
        public abstract Task<GamesSearchResponse?> SearchGamesByName(string gameName);
    }
}