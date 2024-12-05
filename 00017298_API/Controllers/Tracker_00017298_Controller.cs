using _00017298_API.Data;
using _00017298_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _00017298_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Tracker_00017298_Controller : ControllerBase
    {
        private readonly StudentGradeTracker_00017298_DbContext _dbContext;
        public Tracker_00017298_Controller(StudentGradeTracker_00017298_DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<IEnumerable<StudentGradeTracker_00017298>> GetAll() => await _dbContext.StudentGradeTracker_00017298s.ToArrayAsync();

        [HttpGet("id")]
        [ProducesResponseType(typeof(StudentGradeTracker_00017298), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> GetByID(int id)
        {
            var resultedGradeTracker = await _dbContext.StudentGradeTracker_00017298s.FindAsync(id);
            return resultedGradeTracker == null ? NotFound() : Ok(resultedGradeTracker);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public async Task<IActionResult> Create(StudentGradeTracker_00017298 tracker_00017298)
        {
            await _dbContext.StudentGradeTracker_00017298s.AddAsync(tracker_00017298);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetByID), new { id = tracker_00017298.Id }, tracker_00017298);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, StudentGradeTracker_00017298 tracker_00017298)
        {
            if (id != tracker_00017298.Id) return BadRequest();
            _dbContext.Entry(tracker_00017298).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var StudentGradeTrackertoDelete = await _dbContext.StudentGradeTracker_00017298s.FindAsync(id);
            if (StudentGradeTrackertoDelete == null) return NotFound();

            _dbContext.StudentGradeTracker_00017298s.Remove(StudentGradeTrackertoDelete);
            await _dbContext.SaveChangesAsync();
            return NoContent();


        }
    }
}
