using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace PASCUA_LabActivity.Models
{
    public class LoginViewModel
    {
        [Display(Name ="UserName")]
        [Required(ErrorMessage = "a username is required")]
        public string ? UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "a password is required")]
        public string? Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

    }
}
