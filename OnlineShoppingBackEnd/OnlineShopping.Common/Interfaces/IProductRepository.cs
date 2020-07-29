using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Common.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<Product>> ListAllAsync();
    }
}
