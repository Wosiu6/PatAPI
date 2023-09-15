using Microsoft.AspNetCore.Mvc;
using PatSite.Shared;

namespace PatSite.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SteamGamesController : ControllerBase
    {
        private readonly ILogger<SteamGamesController> _logger;

        public SteamGamesController(ILogger<SteamGamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<SteamGame> Get()
        {
            yield return new SteamGame();
        }
    }
}