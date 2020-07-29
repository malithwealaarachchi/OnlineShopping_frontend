using Microsoft.EntityFrameworkCore.Internal;
using OnlineShopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Data
{
    public class OnlineshoppingSeedAsync
    {
        public static async Task SeedAsync(OnlineshoppingContext onlineshoppingContext)
        {
            if(!onlineshoppingContext.Categories.Any())
            {
                onlineshoppingContext.Categories.AddRange(new List<Category>
                {
                    new Category
                    {
                        Id =1,
                        CatName ="Kids"
                    },
                     new Category
                    {
                         Id=2,
                        CatName ="Home accessories"
                    },
                });
                await onlineshoppingContext.SaveChangesAsync();
            }
            if (!onlineshoppingContext.Products.Any())
            {
                onlineshoppingContext.Products.AddRange(new List<Product>
                {
                    new Product
                    {
                        Id=1,
                        CatId = 1,
                        Name ="kids hair accessories.",
                        BuyingUnitPrice=20,
                        SellingPrice = 30,
                        Qty =10
                    },
                    new Product
                    {
                        Id=2,
                        CatId = 1,
                        Name="kids shoes",
                        BuyingUnitPrice =100,
                        SellingPrice=150,
                        Qty = 20
                    }
                });
                await onlineshoppingContext.SaveChangesAsync();

            }
        }
    }
}
