using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class StaffModel : Person
    {
        public int StaffId { get; set; }

        public string StaffRole { get; set; }

        public DateTime DateOfJoining { get; set; }

        public StaffModel() : base()
        {

        }
    }
}
