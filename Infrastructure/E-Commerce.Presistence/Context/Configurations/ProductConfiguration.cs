using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.Presistence.Context.Configurations
{
    internal class ProductConfiguration:IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(256);

            builder.Property(x => x.Description)
              .HasColumnType("nvarchar")
             .HasMaxLength(512);

            builder.Property(x => x.pictureUrl)
             .HasColumnType("nvarchar")
             .HasMaxLength(256);

            builder.Property(x => x.price)
             .HasColumnType("decimal(10,2)")
             .HasMaxLength(256);

            builder.HasOne(x => x.productBrand)
                .WithMany()
                .HasForeignKey(x => x.BrandId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(x => x.productType)
                .WithMany()
                .HasForeignKey(x => x.TypeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
