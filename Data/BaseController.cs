using Microsoft.AspNetCore.Mvc;
using app.Data;

namespace app.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : ControllerBase
        where TEntity : class
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await repository.Get(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            //if (id != entity.Id)
            //{
            //    return BadRequest();
            //}
            var newentity = await repository.Update(entity);
             if (newentity == null)
            {
                return NotFound();
            }
            return CreatedAtAction("Get", entity);
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await repository.Add(entity);
            //return CreatedAtAction("Get", new { id = entity.Id }, entity);
            return CreatedAtAction("Get", entity);
             
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }
    //    [HttpGet]
    //     [Route("search/{search}")]
    //     public async Task<ActionResult<TEntity>> Search(string search)
    //     {
    //         return Ok(await repository.FindByConditionAsync(a =>a.Name == customerName));
    //     }

    }
}