using EatWell.API.DTO.Requests;
using EatWell.API.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Persistence
{
    public interface IUserRepository
    {
        Task<IEnumerable<GetUserResponse>> GetUsersAsync();
        Task<GetUserResponse> GetUserByIdAsync(int id);
        Task DeleteUserById(int id);
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest user);
        Task<UpdateUserResponse> UpdateUserAsync(int id, UpdateUserRequest user);
    }
}
