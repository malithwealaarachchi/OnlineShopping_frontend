using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Common.BusinessInterfaces;
using OnlineShopping.Common.Models;

namespace OnlineShopping.Business.AccountBusiness
{
    public class LoginBusiness : ILoginBusiness
    {
        private readonly IUserRepository _userRepository;

        public LoginBusiness(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

      
        public async Task<User> LoginUser(User userModel)
        {
            return await _userRepository.loginUser(userModel).ConfigureAwait(false);
        }

        public async Task<User> UserRegistration(User userModel)
        {
            return await _userRepository.UserRegistration(userModel).ConfigureAwait(false);
        }
    }
}
