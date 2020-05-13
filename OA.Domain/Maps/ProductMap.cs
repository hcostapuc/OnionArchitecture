using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Maps
{
    public class ProductMap
    {
        public ProductMap(EntityTypeBuilder<ProductEntity> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(p => p.Id);

            entityTypeBuilder.Property(p => p.Name).IsRequired();

            entityTypeBuilder.HasOne(p => p.ProductDetail)
                .WithOne(pd => pd.Product)
                .HasForeignKey<ProductDetailEntity>(prd => prd.Id);
        }
    }
}
