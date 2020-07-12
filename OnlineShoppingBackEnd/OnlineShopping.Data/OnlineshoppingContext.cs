using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Common.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace OnlineShopping.Data
{
    public class OnlineshoppingContext : IdentityDbContext 
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
