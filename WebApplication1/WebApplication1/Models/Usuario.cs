using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("dbo.Usuario")]
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Surnames { get; set; }
        [Required, StringLength(50)]
        public string Password { get; set; }
    }
}