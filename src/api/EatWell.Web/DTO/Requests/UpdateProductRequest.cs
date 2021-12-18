using System.ComponentModel.DataAnnotations;

namespace EatWell.API.DTO.Requests
{
    using Models;

    public class UpdateProductRequest
    {
        [Required]
        public int Id { get; set; }

        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public UpdateProductRequest(ProductModel p)
        {
            Id = p.Id;
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }
    }
}