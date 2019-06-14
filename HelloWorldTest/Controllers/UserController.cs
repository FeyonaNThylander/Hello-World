using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldTest.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [HttpPost("[action]")]
        public void Input([FromBody]string value)
        {
            var message = "The server says Hello " + value;
            //return message;
        }

     
    }
}
