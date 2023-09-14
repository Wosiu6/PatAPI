using System.Text.RegularExpressions;
using System.Text;
using System.Text.Json;
using SAM.Models.HLTB;
using Infrastructure.Models.HTLB;

namespace PatAPI.Services
{
    public interface IHowLongToBeatService
    {
        public abstract Task<GameSearchResponse?> GetGameByName(string gameName);
        public abstract Task<SingleGameResponse?> GetGameById(string gameName);
        public abstract Task<GamesSearchResponse?> SearchGamesByName(string gameName);
    }
}
