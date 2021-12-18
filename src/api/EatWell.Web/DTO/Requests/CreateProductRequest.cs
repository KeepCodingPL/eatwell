using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EatWell.API.DTO.Requests
{
    using Models;

    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }

        public string Brand { get; set; }

        public List<string> Ingredients { get; set; } = new List<string>();

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public CreateProductRequest(ProductModel p)
        {
            Name = p.Name;
            Brand = p.Brand;
            Ingredients = p.Ingredients;
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }
    }
}