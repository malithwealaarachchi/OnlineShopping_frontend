using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using OnlineShopping.Common.BusinessInterfaces;
using OnlineShopping.Common.Models;
using OnlineShopping.Data.Entities;

namespace OnlineShopping.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly OnlineshoppingContext _dbcontext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserRepository(OnlineshoppingContext dbcontext,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager )
           
        {
            _dbcontext = dbcontext;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<User> loginUser(User userModel)
        {
            var result = await _signInManager.PasswordSignInAsync(userModel.UserName, userModel.Password, false, false);
            if (result.Succeeded)
            {
                return userModel;
            }
            else
                return null;
        }

        public async Task<User> UserRegistration(User UserModel)
        {
            var user = new ApplicationUser { UserName = UserModel.UserName, Email = UserModel.Email , PhoneNumber = UserModel.PhoneNumber };
            var result =  await _userManager.CreateAsync(user, UserModel.Password);

            if (result.Succeeded)
            {
               await _signInManager.SignInAsync(user, isPersistent: false);
                return (UserModel);
            }
            return null; 
        }
    }
}
