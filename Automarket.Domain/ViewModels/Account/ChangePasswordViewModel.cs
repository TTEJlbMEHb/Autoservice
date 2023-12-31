﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.ViewModels.Account
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Enter your email")]
        [MinLength(7, ErrorMessage = "Email must be greater than 7")]
        [MaxLength(50, ErrorMessage = "Email must be less than 50")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your password")]        
        [MinLength(6, ErrorMessage = "Password must be greater than 6")]
        [MaxLength(30, ErrorMessage = "Password must be less than 30")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
    }
}
