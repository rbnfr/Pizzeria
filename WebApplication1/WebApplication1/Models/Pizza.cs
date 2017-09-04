using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("dbo.Pizza")]
    public class Pizza
    {
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        [Required, StringLength(200)]
        public string Photo { get; set; }

        public List<Ingrediente> Ingredients { get; set; }

        public List<Comentario> Comments { get; set; }

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