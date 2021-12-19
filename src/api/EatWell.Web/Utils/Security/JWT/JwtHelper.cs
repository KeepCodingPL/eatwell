using EatWell.API.Models;
using EatWell.API.Utils.Security.Encryption;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace EatWell.API.Utils.Security.JWT
{
    public class JwtHelper : ITokenHelper
    {
        private static UserModel user1 = new UserModel { UserId = 1, Email = "email1.com", Password = "pass1" };
        private static UserModel user2 = new UserModel { UserId = 2, Email = "email2.com", Password = "pass2" };
        private readonly IDictionary<string,string> users = new Dictionary<string, string> { { user1.Email, user1.Password }, { user2.Email, user2.Password } };
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        public bool SignIn(UserModel user)
        {
            if (!users.Any(u => u.Key == user.Email && u.Value == user.Password))
            {
                return false;
            }
            return true;
        }
        public AccessToken CreateToken(UserModel user)
        {
            if (!SignIn(user))
                return null;
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
            var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials);
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, UserModel user,
            SigningCredentials signingCredentials)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user),
                signingCredentials: signingCredentials
            ) ;
            return jwt;
        }
        private IEnumerable<Claim> SetClaims(UserModel user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,user.Email)
            };
            
            return claims;
        }
    }
}
