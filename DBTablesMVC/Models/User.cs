using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DBTablesMVC.Models
{
    public class User : IdentityUser
    {
        [Required]
        [StringLength(50)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyBusinessIdentity { get; set; }

        [StringLength(50)]
        public string RoleInCompany { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }


        [Required]
        [StringLength(50)]
        public string LastName { get; set; }


        [Required]
        public byte RightsLevel { get; set; } //reader =0, writer =10, localAdministrator = 20, administrator=50

        [Required]
        public bool IsActive { get; set; }

        [Required]
        [StringLength(450)]
        public byte CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }


        //For Foreign keys
        public virtual ICollection<DldColumn> DldColumn { get; set; }
        public virtual ICollection<DldDatabase> DldDatabase { get; set; }
        public virtual ICollection<DldSchema> DldSchema { get; set; }
        public virtual ICollection<DldTable> DldTable { get; set; }
        public virtual ICollection<DldVersionNumber> DldVersionNumber { get; set; }
    }
}
