using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Common.Models;
using OnlineShopping.Common.Interfaces;

namespace OnlineShopping.webApplication.Controllers
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsBusiness _productsBusiness;

        public ProductsController(IProductsBusiness productsBusiness)
        {
            _productsBusiness = productsBusiness;
        }

        [Route("api/Products/GetProducts")]
        [HttpGet]
        public async Task <IEnumerable<Product>> GetProducts()
        {
            return await _productsBusiness.GetProduts().ConfigureAwait(false);
            
        }

    }

}