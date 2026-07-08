using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Savings.Models;
using UserEntity = FinanceApp.User.Models.User;


namespace FinanceApp.Savings.Interfaces
{
    public interface ISavingsRepository
    {
        Task<List<Saving>> GetAllSavingsAsync();
        Task<UserEntity?> GetByIdAsync(int id);
        Task<Saving> CreateSavingAsync(Saving saving);
        Task<Saving?> UpdateSavingAsync(int id, Saving saving);
        Task<bool> DeleteSavingAsync(int id);
    }
}