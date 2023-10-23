using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCore_Learning_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("ThreadDetails")]
        public IActionResult ThreadDetails()
        {
            int nWorkers; // number of processing threads
            int nCompletions; // number of I/O threads
            ThreadPool.GetMaxThreads(out nWorkers, out nCompletions);
            return Ok(new Dictionary<int, int>() { { nWorkers, nCompletions } });
        }
    }
}
