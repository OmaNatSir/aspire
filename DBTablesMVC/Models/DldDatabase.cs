using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class DldDatabase
    {
        [Key]
        public short DatabaseId { get; set; }


        [Required]
        [StringLength(50)]
        public string DatabaseName { get; set; }


        [MaxLength]
        [DataType(DataType.MultilineText)]
        public string DatabaseDescription { get; set; }


        public bool StatusIsNew { get; set; }


        public short CreatedUpdatedBy { get; set; }


        public System.DateTime CreatedUpdatedDate { get; set; }


        public short LastVersionId { get; set; }


        //For Foreign keys
        public virtual DldVersionNumber DldVersionNumber { get; set; }


        public virtual UserList UserList { get; set; }


        public ICollection<DldSchema> DldSchema { get; set; }
    }
}
