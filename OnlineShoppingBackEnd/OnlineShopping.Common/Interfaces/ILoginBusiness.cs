using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OnlineShopping.Common.Models;


namespace OnlineShopping.Common.BusinessInterfaces
{
    public interface ILoginBusiness
    {
        public Task<User> LoginUser(User userModel);
        public Task<User> UserRegistration(User userModel);

    }
}
