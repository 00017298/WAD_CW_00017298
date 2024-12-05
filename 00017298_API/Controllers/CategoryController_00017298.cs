using _00017298_API.Models;
using _00017298_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00017298_API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController_00017298 : ControllerBase
    {
        private readonly IRepository_00017298<Category_00017298> _repository;
        public CategoryController_00017298(IRepository_00017298<Category_00017298> repository)
        {
            _repository = repository;
        }







        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<Category_00017298>> Get()
        {
            return await _repository.GetAllAsync();
        }








        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var resultedCategory = await _repository.GetByIDAsync(id);
            if (resultedCategory == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(resultedCategory);
            }
        }







        // POST api/<CategoryController>
        [HttpPost]
        public async Task<IActionResult> Create(Category_00017298 categories)
        {
            await _repository.AddAsync(categories);
            return CreatedAtAction(nameof(GetByID), new { id = categories.Id }, categories);
        }







        // PUT api/<CategoryController>/5
        [HttpPut]
        public async Task<IActionResult> Update(Category_00017298 categories)
        {
            //if(id!=items.ID) return BadRequest();
            await _repository.UpdateAsync(categories);
            return NoContent();
        }






        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}
