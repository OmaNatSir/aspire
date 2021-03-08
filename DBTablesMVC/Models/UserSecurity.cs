using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.Models
{
    public class UserSecurity
    {
        public short UserSecurityId { get; set; }

        public short UserId { get; set; }


        [Required]
        [StringLength(50)]
        public string UserName { get; set; }


        [Required]
        [StringLength(50)]
        public string Password { get; set; }


        //For Foreign keys
        public virtual UserList UserList { get; set; }
    }
}
