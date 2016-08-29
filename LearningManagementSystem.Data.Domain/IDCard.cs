using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Domain
{
    public class IDCard
    {
        [Key]
        public long ID { get; set; }
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
}
