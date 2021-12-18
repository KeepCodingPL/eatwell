namespace EatWell.API.DTO.Requests
{
    using Models;

    public class UpdateProductRequest
    {
        public bool IsVegan { get; set; }

        public bool IsVegeterian { get; set; }

        public bool IsHalal { get; set; }

        public UpdateProductRequest()
        {

        }

        public UpdateProductRequest(ProductModel p)
        {
            IsVegan = p.IsVegan;
            IsVegeterian = p.IsVegeterian;
            IsHalal = p.IsHalal;
        }
    }
}