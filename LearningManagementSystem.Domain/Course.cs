using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
