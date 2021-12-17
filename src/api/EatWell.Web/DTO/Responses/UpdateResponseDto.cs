using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatWell.API.Models;

namespace EatWell.API.DTO.Responses
{
    public class UpdateResponseDto
    {
        public bool IsVegan { get; set; }
        public bool IsVegeterian { get; set; }
        public bool IsHalal { get; set; }

        public UpdateResponseDto(ProductModel p)
        {
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }

    }
}
