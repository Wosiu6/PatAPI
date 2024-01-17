using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PatAPI.Services;

namespace PatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("OpenCorsPolicy")]
    public class HowLongToBeatController : ControllerBase
    {
        private readonly ILogger<HowLongToBeatController> _logger;
        private readonly IHowLongToBeatService _hltbService;

        public HowLongToBeatController(ILogger<HowLongToBeatController> logger, IHowLongToBeatService hltbService)
        {
            _logger = logger;
            _hltbService = hltbService;
        }

        [HttpPost("getByName/{gameName}")]
        public Task<IActionResult> GetGameByName(string gameName) =>
            HandleRequest(async () => Ok(await _hltbService.GetGameByName(gameName)), "Game not found.");

        [HttpPost("search/{gameName}")]
        public Task<IActionResult> GetGamesByName(string gameName) =>
            HandleRequest(async () => Ok(await _hltbService.SearchGamesByName(gameName)), "Games not found.");

        [HttpGet("getById/{gameId}")]
        public Task<IActionResult> GetGameById(string gameId) =>
            HandleRequest(async () => Ok(await _hltbService.GetGameById(gameId)), "Game not found.");

        [HttpGet("getBuildId")]
        public Task<IActionResult> GetBuildId() =>
            HandleRequest(async () => Ok(await _hltbService.GetBuildId()), "Build Id could not be retrieved.");

        private async Task<IActionResult> HandleRequest(Func<Task<IActionResult>> action, string errorMessage)
        {
            try
            {
                return await action.Invoke();
            }
            catch (Exception e)
            {
                _logger.LogError(e, errorMessage);
                return NotFound(errorMessage);
            }
        }
    }
}