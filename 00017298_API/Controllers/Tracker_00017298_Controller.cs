using _00017298_API.Data;
using _00017298_API.Models;
using _00017298_API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _00017298_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tracker_00017298_Controller : ControllerBase
    {

        private readonly IRepository_00017298<StudentGradeTracker_00017298> _studentGradeTracker_00017298_Repository;
        public Tracker_00017298_Controller(IRepository_00017298<StudentGradeTracker_00017298> studentGradeTracker_00017298_Repository)
        {
            _studentGradeTracker_00017298_Repository = studentGradeTracker_00017298_Repository;
        }










        [HttpGet]
        public async Task<IEnumerable<StudentGradeTracker_00017298>> GetAll() => await _studentGradeTracker_00017298_Repository.GetAllAsync();














        [HttpGet("{id}")]
        [ProducesResponseType(typeof(StudentGradeTracker_00017298), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetByID(int id)
        {
            var resultedToDo = await _studentGradeTracker_00017298_Repository.GetByIDAsync(id);
            return resultedToDo == null ? NotFound() : Ok(resultedToDo);
        }
















        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(StudentGradeTracker_00017298 items)
        {
            await _studentGradeTracker_00017298_Repository.AddAsync(items);
            return Ok(items);
            //return CreatedAtAction(nameof(GetByID), new { id = items.ID }, items);
        }













        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(StudentGradeTracker_00017298 items)
        {
            //if(id!=items.ID) return BadRequest();
            await _studentGradeTracker_00017298_Repository.UpdateAsync(items);
            return NoContent();
        }












        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentGradeTracker_00017298_Repository.DeleteAsync(id);
            return NoContent();


        }
    }
}
