﻿using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class CredentialsDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
