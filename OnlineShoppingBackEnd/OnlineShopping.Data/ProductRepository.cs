using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Common.Interfaces;
using OnlineShopping.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineshoppingContext _dbcontext;

        public ProductRepository(OnlineshoppingContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<IReadOnlyList<Product>> ListAllAsync()
        {
            return await _dbcontext.Set<Product>().ToListAsync();
        }
    }
}
