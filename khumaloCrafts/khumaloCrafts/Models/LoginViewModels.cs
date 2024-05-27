﻿using System.ComponentModel.DataAnnotations;

namespace khumaloCrafts.Models
{
    
        using System.ComponentModel.DataAnnotations;

public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }

}

