using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
{
    public class Resources
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        public int HoursPerDay { get; set; }

        public int? ProjectsId { get; set; }
        public virtual Projects? Projects { get; set; }
    }
}
