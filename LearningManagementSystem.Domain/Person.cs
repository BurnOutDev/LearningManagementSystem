using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain
{
    public class Person : BaseModel
    {
        [Key]
        public long PersonID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IDCard IDCard { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }
        public string Address { get; set; }
    }

    public class IDCard
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string PrivateNumber { get; set; }
        public string CardNumber { get; set; }
        public string Citizenship { get; set; } //Enum
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfExpiry { get; set; }
        public string Signature { get; set; } // Picture
        public DateTime DateOfIssue { get; set; }
        public string IssuingAuthority { get; set; }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

}
