using _00017298_API.Data;
using _00017298_API.Models;
using Microsoft.EntityFrameworkCore;

namespace _00017298_API.Repositories
{
    public class CategoryRepository_00017298 : IRepository_00017298<Category_00017298>
    {
        private readonly StudentGradeTracker_00017298_DbContext _context;


       

        public CategoryRepository_00017298(StudentGradeTracker_00017298_DbContext context)
        {
            _context = context;
        }





        public async Task AddAsync(Category_00017298 categories)
        {
            await _context.Categories_00017298.AddAsync(categories);
            await _context.SaveChangesAsync();
        }


        
   





        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Categories_00017298.FindAsync(id);
            if (entity != null)
            {
                _context.Categories_00017298.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }







        public async Task<IEnumerable<Category_00017298>> GetAllAsync() => await _context.Categories_00017298.ToArrayAsync();



        public async Task<Category_00017298> GetByIDAsync(int id) => await _context.Categories_00017298.FindAsync(id);



       

        public async Task UpdateAsync(Category_00017298 categories)
        {
            _context.Entry(categories).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }




    }
}
