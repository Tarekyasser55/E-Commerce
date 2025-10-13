using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Presistence.Context
{
    internal class AplicationDbContext(DbContextOptions<AplicationDbContext>options):DbContext(options)
    {
        public DbSet<product> products { set; get; }
        public DbSet<productType> productType { set; get; }
        public DbSet<productBrand> productBrand { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
