using EatWell.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EatWell.API.Persistence
{
    public class EatWellContext : DbContext
    {
        public EatWellContext()
        {
            Products = new List<ProductModel>();
        }
        public ICollection<ProductModel> Products { get; set; }
    }
}
 