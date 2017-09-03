using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public int Puntuation { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Pizza Pizza { get; set; }
    }
}