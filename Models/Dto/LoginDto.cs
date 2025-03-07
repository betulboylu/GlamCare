using System;
using System.ComponentModel.DataAnnotations;

namespace GlamCare.Models
{
    /// <summary>
    /// Login data
    /// </summary>
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
