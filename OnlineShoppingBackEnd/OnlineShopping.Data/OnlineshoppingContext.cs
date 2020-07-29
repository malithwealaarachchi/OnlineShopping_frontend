using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineShopping.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Data.SqlClient;

namespace OnlineShopping.Data
{
    public class OnlineshoppingContext :  IdentityDbContext<ApplicationUser> 
    {
        public OnlineshoppingContext(DbContextOptions<OnlineshoppingContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>(ConfigureCategory);
            builder.Entity<Product>(ConfigureProduct);

        }
        private void ConfigureCategory(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CatName);
            
        }
        private void ConfigureProduct(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name);
            builder.Property(e => e.BuyingUnitPrice);
            builder.Property(e => e.SellingPrice);
            builder.Property(e => e.SellingPrice);
            builder.Property(e => e.Qty);
            builder.HasOne(e => e.Category).WithMany(e => e.CategoryProduct).HasForeignKey(e => e.CatId);
        }
    }
}
