using EatWell.API.DTO.Requests;
using EatWell.API.Models;
using EatWell.API.Utils.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Services
{
    public interface IAuthService
    {
        bool Register(UserForRegister userToRegister);
        Task<bool> LoginAsync(UserLoginRequest user);
        bool UserExists(string email);
        AccessToken CreateAccessToken(UserModel userModel);
    }
}
