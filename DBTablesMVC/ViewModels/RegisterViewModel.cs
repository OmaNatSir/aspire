using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DBTablesMVC.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Company name")]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Business identity code")]
        public string CompanyBusinessIdentity { get; set; }

        [StringLength(25)]
        [Display(Name = "Title")]
        public string RoleInCompany { get; set; }


        [Required]
        [StringLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(25)]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")] 
        public string Password { get; set; }    

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }

    }
}
