using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using EatWell.API.Models;


namespace EatWell.API.DTO.Requests
{
    public class UpdateProductRequest
    {
        [Required]
        public int IdProduct { get; set; }
        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsHalal { get; set; }

        public UpdateProductRequest(ProductModel p)
        {
            IdProduct = p.IdProduct;
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;

        }

    }
}
