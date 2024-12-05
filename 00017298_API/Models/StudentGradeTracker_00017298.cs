using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _00017298_API.Models
{
    public class StudentGradeTracker_00017298
    {
        [Required]
        public int Id { get; set; }


        [Required]
        public int Mark { get; set; }



        [Required(ErrorMessage = "Title is required")]
        public string? Assignment { get; set; }
        
        
        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category_00017298? Category { get; set; }








    }
}
