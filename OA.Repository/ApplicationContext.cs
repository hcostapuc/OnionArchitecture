using Microsoft.EntityFrameworkCore;
using OA.Domain.Entities;
using OA.Domain.Maps;
using System;

namespace OA.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<ProductEntity>());
            new ProductDetailMap(modelBuilder.Entity<ProductDetailEntity>());
        }
    }
}
