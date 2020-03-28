using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DHFashion.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; }
        public String ClothesName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
