using EatWell.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Persistence
{
    public class EatWellContext : DbContext
    {
        public DbSet<ProductModel> Products { get; set; }
    }
}
