using Microsoft.AspNetCore.Mvc;
using System.Text;
using MC.WebApiServices.Models;

namespace MC.WebApiServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world!";
        }

        [HttpGet("hello")]
        public string Get([FromQuery] int count)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i=0; i < count; i++)
            {
                stringBuilder.AppendLine("Hello world!");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Method that return Hello list.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="count">Count.</param>
        /// <returns>List with specific count of hellos.</returns>
        [HttpGet("names/{name}")]
        public string Get([FromRoute] string name, [FromQuery] int count)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                stringBuilder.AppendLine($"Hello {name}!");
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Method that return the Perimeter and the Area of rectangle
        /// </summary>
        /// <param name="a">first side.</param>
        /// <param name="b">second side.</param>
        /// <returns></returns>
        [HttpGet("calculator")]
        [ProducesResponseType(typeof(Rectangle), StatusCodes.Status200OK)]
        public IActionResult Calculate([FromQuery] string a, [FromQuery] string b)
        {           
            return Ok(new Rectangle(a, b));           
        }
    }
}
