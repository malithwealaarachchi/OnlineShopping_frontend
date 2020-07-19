using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineShopping.Data.Entities;

namespace OnlineShopping.Data
{
    public class OnlineshoppingContext : IdentityDbContext<ApplicationUser> 
    {
        public OnlineshoppingContext(DbContextOptions<OnlineshoppingContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
