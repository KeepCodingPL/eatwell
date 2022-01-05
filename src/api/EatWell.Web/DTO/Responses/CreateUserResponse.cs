using EatWell.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.DTO.Responses
{
    public class CreateUserResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
       
        public CreateUserResponse(UserModel u)
        {
            UserId = u.UserId;
            FirstName = u.FirstName;
            LastName = u.LastName;
            Email = u.Email;
            PasswordHash = u.PasswordHash;
            PasswordSalt = u.PasswordSalt;
            Status = u.Status;

        }
    }
}
