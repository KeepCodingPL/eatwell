using EatWell.API.Models;
using EatWell.API.Utils.Security.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AuthController : ControllerBase
    {
        private readonly ITokenHelper _tokenHelper;
        public AuthController(ITokenHelper _itokenHelper)
        {
            this._tokenHelper = _itokenHelper;
        }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody] UserModel userCred)
        {
            var token = _tokenHelper.CreateToken(userCred);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
        [HttpGet]
        
        public IEnumerable<string> Get()
        {
            return new string[] { "new jersey", "new york" };
        }
    }
}
