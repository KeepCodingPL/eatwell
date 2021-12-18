using System.ComponentModel.DataAnnotations;

namespace EatWell.API.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Ingredients { get; set; }

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }
    }
}