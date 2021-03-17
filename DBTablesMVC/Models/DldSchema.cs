using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class DldSchema
    {
        [Key]
        public byte SchemaId { get; set; }

        [Required]
        [StringLength(50)]
        public string SchemaName { get; set; }


        [StringLength(255)]
        public string SchemaNote { get; set; }


        public bool StatusIsNew { get; set; }


        public short CreatedUpdatedBy { get; set; }


        public System.DateTime CreatedUpdatedDate { get; set; }

        //For Foreign keys
        public virtual DldDatabase DldDatabase { get; set; }


        //public virtual User User { get; set; }


        public virtual ICollection<DldTable> DldTable { get; set; }
    }
}
