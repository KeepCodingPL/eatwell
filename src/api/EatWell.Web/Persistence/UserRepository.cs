using EatWell.API.DTO.Requests;
using EatWell.API.DTO.Responses;
using EatWell.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly EatWellContext _eatWellContext;
        public UserRepository(EatWellContext eatWellContext)
        {
            this._eatWellContext = eatWellContext;
        }
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest user)
        {
            var userToAdd = new UserModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt,
                Status = user.Status
            };
            _eatWellContext.Entry(userToAdd).State = EntityState.Added;
            await _eatWellContext.SaveChangesAsync();
            return new CreateUserResponse(userToAdd);
        }

        public async Task DeleteUserById(int id)
        {
            var user = await _eatWellContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
            _eatWellContext.Entry(user).State = EntityState.Deleted;
            await _eatWellContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<GetUserResponse>> GetUsersAsync() => await _eatWellContext.Users.Select(u => new GetUserResponse(u)).ToListAsync();
        

        public async Task<GetUserResponse> GetUserByIdAsync(int id)
        {
            var user = await _eatWellContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
            return user is null ? null : new(user);
        }
        public async Task<GetUserResponse> GetByEmailAsync(string email)
        {
            var user = await _eatWellContext.Users.FirstOrDefaultAsync(u => u.Email.Equals(email));
            return user is null ? null : new(user);
        }
        
        public async Task<UpdateUserResponse> UpdateUserAsync(int id, UpdateUserRequest updateRequest)
        {
            var userInList = await _eatWellContext.Users.FirstOrDefaultAsync(u => u.UserId == id);
            if (userInList is null)
            {
                throw new Exception("User not defined");
            }
            userInList.Status = updateRequest.Status;

            _eatWellContext.Entry(userInList).State = EntityState.Modified;
            await _eatWellContext.SaveChangesAsync();
            return new UpdateUserResponse(userInList);
        }

        
    }
}
