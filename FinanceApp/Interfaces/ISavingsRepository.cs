using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Models;

namespace FinanceApp.Interfaces
{
    public interface ISavingsRepository
    {
        Task<List<Saving>> GetAllSavingsAsync();
        Task<User?> GetByIdAsync(int id);
        Task<Saving> CreateSavingAsync(Saving saving);
        Task<Saving?> UpdateSavingAsync(int id, Saving saving);
        Task<bool> DeleteSavingAsync(int id);
    }
}