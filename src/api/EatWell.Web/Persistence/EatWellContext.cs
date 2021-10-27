using EatWell.API.Models;
using Microsoft.EntityFrameworkCore;


namespace EatWell.API.Persistence
{
    public class EatWellContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}