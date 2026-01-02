using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Interfaces;
using FinanceApp.Models;
using Microsoft.EntityFrameworkCore;


namespace FinanceApp.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _context;
        public UserRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<User> CreateUserAsync(User user)
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
        public async Task<User?> UpdateUserAsync(int id, User updateUser)
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

        public Task<List<User>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.User.FindAsync(id);
        }
        public async Task<List<User>> GettAllUsersAsync()
        {
            return await _context.User.ToListAsync();
        }
    }
}