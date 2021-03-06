using System.ComponentModel.DataAnnotations;

namespace ClassProjectLibrary1
    {
    public class Work
        {
        public int Id { get; set; } = 0;
                
        public int ResourcesId { get; set; } = 0;
        [StringLength(100)]
        public string Description { get; set; } = null!;

        public int Hours { get; set; } = 0;

    
        public virtual Resources? Resources { get; set; }
        }
    }