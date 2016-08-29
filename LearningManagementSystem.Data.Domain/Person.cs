using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Domain
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

        #region User

        #region Private Variables

        private string _password;
        private bool _forceUserToChangePassword;

        #endregion

        [StringLength(450)]
        public string Username { get; set; }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                ForceUserToChangePassword = false;
            }
        }
        public string Salt { get; set; }

        public DateTime LastPasswordChangeDate { get; set; }

        public bool IsLockedOut { get; set; }

        public bool ForceUserToChangePassword
        {
            get { return _forceUserToChangePassword; }
            set
            {
                _forceUserToChangePassword = value;
                if (value == false)
                {
                    LastPasswordChangeDate = DateTime.Now;
                }
            }
        }

        #endregion

        public virtual ICollection<UploadedFile> Files { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
