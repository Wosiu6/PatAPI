using Microsoft.AspNetCore.Authentication;
using SAM.Game.HLTB;

namespace PatAPI.Clients
{
    public interface IHowLongToBeatClient
    {
        

        public abstract Task<GamesSearchResponse?> SearchGameByName(string gameName);
    }
}