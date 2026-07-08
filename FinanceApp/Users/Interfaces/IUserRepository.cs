using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserEntity = FinanceApp.Users.Models.User;

namespace FinanceApp.Users.Interfaces
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAllUsersAsync();
        Task<UserEntity?> GetByIdAsync(int id);
        Task<UserEntity> CreateUserAsync(UserEntity user);
        Task<UserEntity?> UpdateUserAsync(int id, UserEntity user);
        Task<bool> DeleteUserAsync(int id);
    }
}