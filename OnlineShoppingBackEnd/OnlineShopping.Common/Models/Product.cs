using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BuyingUnitPrice { get; set;}
        public int SellingPrice { get; set; }
        public int Qty { get; set; }

    }
}
