using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace OnlineShopping.Common.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
