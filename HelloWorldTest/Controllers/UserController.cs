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
        public string Input([FromBody]User value)
        {
            var userInput = value.UserInput;
            var message = "The server says Hello " + userInput;
            return message;
        }

     
    }
}
