using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Common.Models;
using OnlineShopping.Common.BusinessInterfaces;

namespace OnlineShopping.webApplication.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginBusiness _loginBusiness;
        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }
        
        [Route("api/Login/UserEnroll")]
        [HttpPost]
        public async Task<IActionResult> UserEnroll(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                return BadRequest();
            }
            else
            {
                try
                {
                    var result = await _loginBusiness.LoginUser(userModel).ConfigureAwait(false);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return StatusCode(500, "Internal server error");
                }
            }
        }
        [Route("api/Login/UserRegister")]
        [HttpPost] 
        public async Task<IActionResult> UserRegister(User userModel)
        {
            if (string.IsNullOrEmpty(userModel.UserName) || string.IsNullOrEmpty(userModel.Password))
            {
                return BadRequest();
            }
            else
            {
                try
                {
                    var result =  await _loginBusiness.UserRegistration(userModel);
                    return Ok(result);
                }
                catch (Exception)
                {
                    return StatusCode(500, "Internal server error");
                }
            }
        }
             
    }
}