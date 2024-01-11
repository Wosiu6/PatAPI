using Microsoft.AspNetCore.Mvc;
using PatAPI.Services;

namespace PatAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameLibraryController : ControllerBase
    {
        private readonly ILogger<HowLongToBeatController> _logger;
        private readonly IHowLongToBeatService _hltbService;

        public GameLibraryController(ILogger<HowLongToBeatController> logger, IHowLongToBeatService hltbService)
        {
            _logger = logger;
            _hltbService = hltbService;
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