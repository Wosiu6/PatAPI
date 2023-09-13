using System.Text.RegularExpressions;
using System.Text;
using System.Text.Json;
using SAM.Game.HLTB;

namespace PatAPI.Services
{
    public interface IHowLongToBeatService
    {
        public abstract Task<GameSearchResponse?> GetGameByName(string gameName);
    }
}
