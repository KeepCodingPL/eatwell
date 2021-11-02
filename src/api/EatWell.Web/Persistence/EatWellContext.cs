using EatWell.API.Models;
using Microsoft.EntityFrameworkCore;


namespace EatWell.API.Persistence
{
    public class EatWellContext : DbContext
    {
        
        public EatWellContext(DbContextOptions<EatWellContext> options) : base(options)
        {

        }

        public virtual DbSet<ProductModel> Products { get; set; }
    }
}