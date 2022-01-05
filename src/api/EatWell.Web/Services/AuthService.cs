using EatWell.API.DTO.Requests;
using EatWell.API.Models;
using EatWell.API.Utils.Security.Hashing;
using EatWell.API.Utils.Security.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        
        public AuthService(IUserService iuserService)
        {
            _userService = iuserService;
            
        }
        public AccessToken CreateAccessToken(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LoginAsync(UserLoginRequest user)
        {
            var userToCheck = await _userService.GetUserByEmail(user.Email);
        
            
            return HashingHelper.VerifyPasswordHash(user.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt) ;
        }

        public bool Register(UserForRegister userRegister)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userRegister.Password, out passwordHash, out passwordSalt);
            var user = new CreateUserRequest
            {
                FirstName = userRegister.FirstName,
                LastName = userRegister.LastName,
                Email = userRegister.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            _userService.CreateUserAsync(user);
            return true;
        }

        public bool UserExists(string email)
        {
            throw new NotImplementedException();
        }

    }
}
