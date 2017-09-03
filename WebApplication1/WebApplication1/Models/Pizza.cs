using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pizza
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public List<Ingrediente> Ingredients { get; set; }
        public List<Commentario> Comments { get; set; }

        public Decimal Price
        {
            get
            {
                return Ingredients.Sum(i => i.Price) + 5;
            }
            set
            {
                Price = value;

            }
        }
    }
}