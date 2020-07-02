using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Common.Models;

namespace OnlineShopping.webApplication.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
   
        public LoginController()
        {

        }

        [Route("api/Login")]
        [Route("api/Login/UserEnroll")]
       public string UserEnroll()
        {
             return "this is user enroll";
        }
    }
}