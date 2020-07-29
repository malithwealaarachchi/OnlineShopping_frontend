using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Common.Interfaces;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Business.ProductBusiness
{
    public class ProductsBusiness : IProductsBusiness
    {
        private readonly IProductRepository _productRepository;

        public ProductsBusiness(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> GetProduts()
        {

            //var result = await _productRepository.ListAllAsync().ConfigureAwait(false);
            //return result;

            
                IList<Product> productlist = new List<Product>()
            {
                new Product()
                {
                    Id =1, Name="Manchi", BuyingUnitPrice = 20, SellingPrice= 30,Qty=10
                },
                new Product()
                {
                    Id =2, Name="maliban", BuyingUnitPrice = 20, SellingPrice= 30,Qty=10
                },
                new Product()
                {
                    Id =3, Name="Rio", BuyingUnitPrice = 20, SellingPrice= 30,Qty=10
                },
            };
                return productlist;
            }
    }
}
