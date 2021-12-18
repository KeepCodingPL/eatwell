using System.Collections.Generic;

namespace EatWell.API.DTO.Responses
{
    using Models;

    public class CreateProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public List<string> Ingredients { get; set; } = new List<string>();

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public CreateProductResponse(ProductModel p)
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