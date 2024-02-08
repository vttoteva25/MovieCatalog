using MC.ApplicationServices.Interfaces;
using MC.ApplicationServices.Messaging.Requests;
using MC.ApplicationServices.Messaging.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace MC.WebApiServices.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class MovieController : ControllerBase
    {
        private readonly IMoviesService _service;

        public MovieController(IMoviesService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get movies by title.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        [HttpGet("search/{title}")]
        [ProducesResponseType(typeof(GetByTitleResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetByTitleAsync([FromRoute] string title)
        {
            return Ok(await _service.GetByTitleAsync(new GetByTitleRequest(title)));
        }

        /// <summary>
        /// Add movie.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task AddMovie([FromBody] MovieModel movie)
        {
            await _service.AddMovieAsync(movie);
        }
    }
}
