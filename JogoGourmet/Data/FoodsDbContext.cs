using JogoGourmet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Data
{
    public class FoodsDbContext : DbContext
    {
        public DbSet<TypeFood> TypeFood { get; set; }
        public DbSet<Food> Food { get; set; }

        public FoodsDbContext(DbContextOptions<FoodsDbContext> options) : base(options) { }
    }
}
