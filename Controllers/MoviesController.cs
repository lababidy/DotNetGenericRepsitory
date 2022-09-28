using Microsoft.AspNetCore.Mvc;
using app.Data;
using app.Models;
using app.Repository;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : BaseController<Movie, MovieRepository>
    {
        public MoviesController(MovieRepository repository) : base(repository)
        {

        }

        [HttpGet("search/{search}")]
        public ActionResult<IEnumerable<string>> Search(String search)
        {
            return new string[] { "value1", "value2"+search };
            
        }
    }
}
