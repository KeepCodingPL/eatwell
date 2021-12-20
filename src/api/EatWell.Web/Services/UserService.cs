using EatWell.API.DTO.Requests;
using EatWell.API.DTO.Responses;
using EatWell.API.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatWell.API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) => _userRepository = userRepository;
        
        public async Task<CreateUserResponse> CreateUserAsync(CreateUserRequest createUserRequest) => await _userRepository.CreateUserAsync(createUserRequest);

        public async Task DeleteUserAsync(int id) => await _userRepository.DeleteUserById(id);

        public async Task<GetUserResponse> GetUserByIdAsync(int id) => await _userRepository.GetUserByIdAsync(id);

        public async Task<IEnumerable<GetUserResponse>> GetUsersAsync() => await _userRepository.GetUsersAsync();

        public async Task<UpdateUserResponse> UpdateUserAsync(int id, UpdateUserRequest updateUserRequest) => await _userRepository.UpdateUserAsync(id, updateUserRequest);
    }
}
