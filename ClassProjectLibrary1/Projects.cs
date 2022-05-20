using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProjectLibrary1
{
    public class Projects
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string Description { get; set; } = string.Empty;
        public int EstimatedHours { get; set; } = 0;
        public int ActualHours { get; set; } = 0;
        public Status Status { get; set; } = Status.New;

    }
    public enum Status
    {
        New, Inprocess, Complete
    }
}
