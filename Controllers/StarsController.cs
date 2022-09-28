using Microsoft.AspNetCore.Mvc;
using app.Data;
using app.Models;
using app.Repository;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarsController : BaseController<Star, StarRepository>
    {
        public StarsController(StarRepository repository) : base(repository)
        {

        }
    }
}