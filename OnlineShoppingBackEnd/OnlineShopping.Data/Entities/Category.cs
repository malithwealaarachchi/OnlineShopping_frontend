using System;
using System.Collections.Generic;
using System.Text;
using OnlineShopping.Data.Entities;


namespace OnlineShopping.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CatName { get; set; }
        public ICollection<Product> CategoryProduct { get; set; }
    }
}
