using _00017298_API.Models;
using _00017298_API.Data;
using Microsoft.EntityFrameworkCore;

namespace _00017298_API.Repositories
{
    public class GradeTrackerRepository_00017298 : IRepository_00017298<StudentGradeTracker_00017298>
    {


        private readonly StudentGradeTracker_00017298_DbContext _context;
        public GradeTrackerRepository_00017298(StudentGradeTracker_00017298_DbContext context)
        {
            _context = context;
        }






        public async Task Create(StudentGradeTracker_00017298 entity)
        {
            _context.StudentGradeTracker_00017298s.Add(entity);
            await _context.SaveChangesAsync();
        }







        public async Task Delete(int id)
        {
            var deletItem = await _context.StudentGradeTracker_00017298s.FindAsync(id);
            if (deletItem != null)
            {
                _context.StudentGradeTracker_00017298s.Remove(deletItem);
                await _context.SaveChangesAsync();
            }
        }




       



        public async Task<StudentGradeTracker_00017298> Get(int id)
        {
            return await _context.StudentGradeTracker_00017298s.FindAsync(id);
        }


        




        public async Task<IEnumerable<StudentGradeTracker_00017298>> GetAll()
        {
            return await _context.StudentGradeTracker_00017298s.ToListAsync();
        }



   








   
        public async Task Update(StudentGradeTracker_00017298 entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
