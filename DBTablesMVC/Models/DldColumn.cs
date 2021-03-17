using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class DldColumn
    {
        [Key]
        public short ColumnId { get; set; }


        [Required]
        [StringLength(255)]
        public string ColumnName { get; set; }


        [Required]
        [StringLength(30)]
        public string ColumnDataType { get; set; }


        public bool ColumnNullability { get; set; }


        [MaxLength]
        [DataType(DataType.MultilineText)]
        public string ColumnDescription { get; set; }


        public bool IsPrimaryKey { get; set; }


        public bool IsForeignKey { get; set; }


        [StringLength(50)]
        public string DefaultValue { get; set; }


        public bool StatusIsNew { get; set; }


        public short CreatedUpdatedBy { get; set; }


        public System.DateTime CreatedUpdatedDate { get; set; }


        //For Foreign keys
        public virtual DldTable DldTable { get; set; }
        //public virtual User User { get; set; }
    }
}
