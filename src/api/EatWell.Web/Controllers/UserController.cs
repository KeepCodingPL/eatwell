using EatWell.API.DTO.Requests;
using EatWell.API.Models;
using EatWell.API.Services;
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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ITokenHelper _tokenHelper;
        private readonly IAuthService _authService;

        public UserController(IUserService userService , ITokenHelper tokenHelper
            ,IAuthService authService)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
            _authService = authService;
        }
        
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _userService.GetUsersAsync());
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> GetAuthenticate([FromBody] UserModel user)
        {
            var result = await _userService.GetUserByIdAsync(user.UserId);
            var token = _tokenHelper.CreateToken(user);
            return result != null ? Ok(token) : NotFound();
        }

        [AllowAnonymous]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var result = await _userService.GetUserByIdAsync(id);


            return result != null ? Ok(result) : NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRequest createUserRequest)
        {
            var result = await _userService.CreateUserAsync(createUserRequest);

            return Ok(result);
        }
        [HttpPost("/register")]
        [AllowAnonymous]
        public IActionResult Register(UserForRegister userRegister)
        {
            var result =  _authService.Register(userRegister);

            return Ok(result);
        }
        [HttpPost("/login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login (UserLoginRequest user)
        {
            var result = await  _authService.LoginAsync(user);
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePorduct(int id, UpdateUserRequest updateRequest)
        {
            var result = await _userService.UpdateUserAsync(id, updateRequest);

            return Ok(result);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await _userService.DeleteUserAsync(id);

            return Ok();
        }
    }
}
