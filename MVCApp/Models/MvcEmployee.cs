using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class MvcEmployee
    {
        [Display(Name ="Employee ID")]
        [Range(100000, 999999, ErrorMessage = "You Need to enter a valid Employee Id.")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You Need to Enter your first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You Need to Enter your last name.")]
        public string LastName { get; set; }

        [Display(Name = "Email Adress")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "You need to give us you email adress.")]
        public string EmailAdress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAdress", ErrorMessage = "The Email and confirm email must match.")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Please enter a valid name.")]
        [Required(ErrorMessage = "You must have a password.")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The Password and confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}