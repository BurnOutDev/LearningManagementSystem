using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain
{
    public class Role
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
