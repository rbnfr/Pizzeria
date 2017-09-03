using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Ingrediente
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}