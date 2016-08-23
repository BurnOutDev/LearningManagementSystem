using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain
{
    public class Teacher : Person
    {
        public ICollection<Course> Courses { get; set; }
    }
}
