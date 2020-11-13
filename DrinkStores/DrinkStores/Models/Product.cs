using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        //public string Img { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Status { get; set; }
    }
}
