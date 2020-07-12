using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShopping.Common.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public string UserName  { get; set; }
        public int PhoneNumber { get; set; }

        public string StreetNumberAndName { get; set; }
        public string NameOfTown { get; set; }
        public int PostCode { get; set; }
    }
}
