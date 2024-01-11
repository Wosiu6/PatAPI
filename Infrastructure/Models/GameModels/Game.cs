
namespace PatAPI.Infrastructure.Models.GameModels
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SteamId { get; set; }
        public string? SteamUrl { get; set; }
    }
}
