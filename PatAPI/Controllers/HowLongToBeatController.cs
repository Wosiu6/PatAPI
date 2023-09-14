using Microsoft.AspNetCore.Mvc;
using PatAPI.Services;

namespace PatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public async Task<IActionResult> GetGameByName(string gameName)
        {
            try
            {
                return Ok(await _hltbService.GetGameByName(gameName));
            }
            catch (Exception e)
            {
                _logger.Log(0, e, e.Message);
                return NotFound("Game not found.");
            }
        }

        [HttpPost("search/{gameName}")]
        public async Task<IActionResult> GetGamesByName(string gameName)
        {
            try
            {
                return Ok(await _hltbService.SearchGamesByName(gameName));
            }
            catch (Exception e)
            {
                _logger.Log(0, e, e.Message);
                return NotFound("Game not found.");
            }
        }
        
        [HttpGet("getById/{gameId}")]
        public async Task<IActionResult> GetGameById(string gameId)
        {
            try
            {
                return Ok(await _hltbService.GetGameById(gameId));
            }
            catch (Exception e)
            {
                _logger.Log(0, e, e.Message);
                return NotFound("Game not found.");
            }
        }
        
        [HttpGet("getBuildId")]
        public async Task<IActionResult> GetBuildId()
        {
            try
            {
                return Ok(await _hltbService.GetBuildId());
            }
            catch (Exception e)
            {
                _logger.Log(0, e, e.Message);
                return NotFound("Game not found.");
            }
        }
    }
}