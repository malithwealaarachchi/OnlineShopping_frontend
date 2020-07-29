using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Data.Entities;

namespace OnlineShopping.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BuyingUnitPrice { get; set; }
        public int SellingPrice { get; set; }
        public int Qty { get; set; }
        public int CatId { get; set; }
        public Category Category { get; set; }
    }
}
