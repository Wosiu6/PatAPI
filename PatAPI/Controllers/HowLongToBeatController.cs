using Microsoft.AspNetCore.Mvc;
using PatAPI.Services;

namespace PatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HowLongToBeatController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IHowLongToBeatService _hltbService;

        public HowLongToBeatController(ILogger<WeatherForecastController> logger, IHowLongToBeatService hltbService)
        {
            _logger = logger;
            _hltbService = hltbService;
        }

        [HttpGet("{gameName}")]
        public async Task<IActionResult> Get(string gameName)
        {
            try
            {
                return Ok(await _hltbService.GetGameByName(gameName));
            }
            catch (Exception)
            {
                return NotFound("Game not found.");
            }
        }
    }
}