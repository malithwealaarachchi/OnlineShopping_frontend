using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using OnlineShopping.Common.BusinessInterfaces;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly OnlineshoppingContext _dbcontext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserRepository(OnlineshoppingContext dbcontext,
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager )
           
        {
            _dbcontext = dbcontext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<string> loginUser(User userModel)
        {
            var result = await _signInManager.PasswordSignInAsync(userModel.Email, userModel.Password, false, false);
            if (result.Succeeded)
            {
                return "login succeeded";
            }
            else
                return "login unsucceeded";
        }
    }
}
