using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace OnlineShopping.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string StreetNumberAndName { get; set; }
        public string NameofTown { get; set; }
        public string Postcode { get; set; }

    }
}
