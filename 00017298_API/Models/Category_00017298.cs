using System.ComponentModel.DataAnnotations;

namespace _00017298_API.Models
{
    public class Category_00017298
    {
        public int Id { get; set; }
        private string _assignment;
        [Required(ErrorMessage = "Name of Assignment is required")]
        public string Assignment
        {
            get => _assignment;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name of Assignment cannot be null or empty.");
                }

                _assignment = value;
            }
        }
    }
}
