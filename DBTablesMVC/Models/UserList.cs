using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBTablesMVC.Models
{
    public class UserList
    {
        [Key]
        public short UserId { get; set; }


        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        public byte RightsLevel { get; set; }


        public bool IsActive { get; set; }

        [Required]
        [StringLength(50)]
        public string EMail { get; set; }


        [StringLength(25)]
        public string Phone { get; set; }


        [StringLength(25)]
        public string Firm { get; set; }


        [StringLength(50)]
        public string Title { get; set; }
        public byte CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }


        //For Foreign keys
        public virtual ICollection<DldColumn> DldColumn { get; set; }
        public virtual ICollection<DldDatabase> DldDatabase { get; set; }
        public virtual ICollection<DldSchema> DldSchema { get; set; }
        public virtual ICollection<DldTable> DldTable { get; set; }
        public virtual ICollection<DldVersionNumber> DldVersionNumber { get; set; }
        public virtual ICollection<UserHistory> UserHistory { get; set; }
        public virtual ICollection<UserSecurity> UserSecurity { get; set; }
    }
}
