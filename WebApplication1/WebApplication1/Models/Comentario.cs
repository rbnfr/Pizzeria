using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("dbo.Comentario")]
    public class Comentario
    {
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(250)]

        public string Text { get; set; }

        [Required]
        public int Puntuation { get; set; }

        public DateTime Date { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        public Pizza Pizza { get; set; }
    }
}