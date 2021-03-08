using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class UserHistory
    {
        public short Id { get; set; }


        public short UserId { get; set; }


        public short UpdatedDeletedBy { get; set; }


        public System.DateTime UpdatedDeletedDate { get; set; }


        [Required]
        [StringLength(255)]
        public string UpdatedDeletedNote { get; set; }


        //For Foreign keys
        public virtual UserList UserList { get; set; }
    }
}