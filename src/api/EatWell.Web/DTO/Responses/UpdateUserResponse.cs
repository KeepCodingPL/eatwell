using EatWell.API.Models;

namespace EatWell.API.DTO.Responses
{
    public class UpdateUserResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }

        public UpdateUserResponse(UserModel u)
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
