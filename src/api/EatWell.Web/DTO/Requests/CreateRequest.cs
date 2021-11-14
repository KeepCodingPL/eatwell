using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.DTO.Requests
{
    public class CreateRequest
    {
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }

        public List<string> Ingredients = new List<string>();

        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsHalal { get; set; }

        public CreateRequest(ProductModel p)
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
