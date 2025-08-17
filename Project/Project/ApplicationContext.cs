using Microsoft.EntityFrameworkCore;
using Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> products { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=anybase.db");
        }
    }
}
