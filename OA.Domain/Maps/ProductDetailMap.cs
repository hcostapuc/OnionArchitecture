using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Domain.Maps
{
    public class ProductDetailMap
    {
        public ProductDetailMap(EntityTypeBuilder<ProductDetailEntity> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.StockAvaliable).IsRequired();
            entityBuilder.Property(p => p.Price);
        }
    }
}
