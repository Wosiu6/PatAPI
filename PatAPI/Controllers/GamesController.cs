using Microsoft.AspNetCore.Mvc;
using PatAPI.Services;

namespace PatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : ControllerBase
    {
        private readonly ILogger<HowLongToBeatController> _logger;
        private readonly IGamesService _gamesService;

        public GamesController(ILogger<HowLongToBeatController> logger, IGamesService gamesService)
        {
            _logger = logger;
            _gamesService = gamesService;
        }
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