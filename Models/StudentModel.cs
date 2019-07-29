using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class StudentModel : Person
    {
        public string StudentId { get; set; }

        public string Class{ get; set; }

        public string  Section { get; set; }
        public bool ShowStudentId => !string.IsNullOrEmpty(StudentId);

        public StudentModel(): base()
        {

        }
    }
}
