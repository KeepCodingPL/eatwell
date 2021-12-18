using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EatWell.API.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public List<string> Ingredients { get; set; } = new List<string>();

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }
    }
}