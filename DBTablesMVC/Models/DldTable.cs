using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class DldTable
    {
        [Key]
        public short TableId { get; set; }

        [Required]
        [StringLength(100)]
        public string TableName { get; set; }

        [MaxLength]
        [DataType(DataType.MultilineText)]
        public string TableDescription { get; set; }


        [StringLength(3)]
        public string TableAlias { get; set; }


        public bool StatusIsNew { get; set; }


        public short CreatedUpdatedBy { get; set; }


        public System.DateTime CreatedUpdatedDate { get; set; }

        //For Foreign keys
        public virtual ICollection<DldColumn> DldColumn { get; set; }
        public virtual DldSchema DldSchema { get; set; }
        //public virtual User User { get; set; }
    }
}
