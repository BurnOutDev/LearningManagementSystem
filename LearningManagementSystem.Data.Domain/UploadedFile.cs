using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Domain
{
    public class UploadedFile : BaseModel
    {
        [Key]
        public long FileID { get; set; }
        public string FileName { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public byte[] BinaryData { get; set; }

        public virtual Person Owner { get; set; }
    }
}
