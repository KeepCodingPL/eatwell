using System.Collections.Generic;

namespace EatWell.API.DTO.Responses
{
    using Utils;
    using Models;

    public class GetProductResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public List<string> Ingredients { get; set; }

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public GetProductResponse(ProductModel p)
        {
            Id = p.Id;
            Name = p.Name;
            Brand = p.Brand;
            Ingredients = IngredientsHelper.IngredientsToList(p.Ingredients);
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }
    }
}