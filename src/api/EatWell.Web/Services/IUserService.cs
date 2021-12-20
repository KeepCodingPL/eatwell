using EatWell.API.DTO.Requests;
using EatWell.API.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Services
{
    public interface IUserService
    {
        Task<IEnumerable<GetUserResponse>> GetUsersAsync();
        Task<GetUserResponse> GetUserByIdAsync(int id);
        Task DeleteUserAsync(int id);
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest);
        Task<UpdateUserResponse> UpdateUserAsync(int id, UpdateUserRequest updateUserRequest);
    }
}
