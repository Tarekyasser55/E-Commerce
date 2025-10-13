using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace E_Commerce.Presistence.Context.Configurations
{
    internal class BrandConfiguration :IEntityTypeConfiguration<productBrand>
    {
        public void Configure(EntityTypeBuilder<productBrand> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(256);
        }
    }
}
