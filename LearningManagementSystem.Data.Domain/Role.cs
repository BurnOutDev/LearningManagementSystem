using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Domain
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Person> Persons { get; set; }
    }
}
