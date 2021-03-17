using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class DldVersionNumber
    {
        [Key]
        public short Id { get; set; }


        [Required]
        [StringLength(30)]
        public string VersionNumber { get; set; }


        [MaxLength]
        public string VersionNote { get; set; }
        public short CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }


        //For Foreign keys
        public virtual ICollection<DldDatabase> DldDatabase { get; set; }
        //public virtual User User { get; set; }
    }
}
