using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.DTO.Requests
{
    using Utils;
    using Models;
    using System.ComponentModel.DataAnnotations;

    public class CreateUserRequest
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }
        public CreateUserRequest()
        {

        }
        public CreateUserRequest(UserModel u)
        {
            UserId = u.UserId;
            FirstName = u.FirstName;
            LastName = u.LastName;
            Email = u.Email;
            Password = u.Password;
            PasswordHash = u.PasswordHash;
            PasswordSalt = u.PasswordSalt;
            Status = u.Status;

        }
    }
}
