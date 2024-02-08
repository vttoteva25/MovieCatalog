using Microsoft.AspNetCore.Mvc;

namespace MC.Data.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    internal class MoviesController : ControllerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MoviesController"/> class.
        /// </summary>
        public MoviesController() { }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok();
    }
}
