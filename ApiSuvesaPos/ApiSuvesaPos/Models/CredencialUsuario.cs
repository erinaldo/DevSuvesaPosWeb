﻿using System.ComponentModel.DataAnnotations;

namespace ApiSuvesaPos.Models
{
    public class CredencialUsuario
    {
        [Required]
        [EmailAddress]

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
