using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Users.Interfaces;
using UserEntity = FinanceApp.Users.Models.User;
using Microsoft.EntityFrameworkCore;


namespace FinanceApp.Users.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _context;
        public UserRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<UserEntity> CreateUserAsync(UserEntity user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            var userModel = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            if (userModel == null)
            {
                return false;
            }
            _context.User.Remove(userModel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<UserEntity?> UpdateUserAsync(int id, UserEntity updateUser)
        {
            var userModel = await _context.User.FirstOrDefaultAsync(x => x.Id == id);
            if (userModel == null)
            {
                return null;
            }
            userModel.Name = updateUser.Name;
            userModel.LastName = updateUser.LastName;
            userModel.Email = updateUser.Email;
            userModel.Password = updateUser.Password;
            userModel.ConfirmPassword = updateUser.ConfirmPassword;
            userModel.Address = updateUser.Address;
            userModel.PhoneNumber = updateUser.PhoneNumber;
            await _context.SaveChangesAsync();
            return userModel;
        }

        public Task<List<UserEntity>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<UserEntity?> GetByIdAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }
        public async Task<List<UserEntity>> GettAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        Task<List<UserEntity>> IUserRepository.GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        Task<UserEntity?> IUserRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}