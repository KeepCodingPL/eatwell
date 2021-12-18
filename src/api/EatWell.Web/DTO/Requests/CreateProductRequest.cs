using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EatWell.API.DTO.Requests
{
    using Utils;
    using Models;

    public class CreateProductRequest
    {
        [Required]
        public string Name { get; set; }

        public string Brand { get; set; }

        public List<string> Ingredients { get; set; }

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public CreateProductRequest()
        {

        }

        public CreateProductRequest(ProductModel p)
        {
            Name = p.Name;
            Brand = p.Brand;
            Ingredients = IngredientsHelper.IngredientsToList(p.Ingredients);
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }
    }
}