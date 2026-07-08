using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Savings.Models;


namespace FinanceApp.Savings.Interfaces
{
    public interface ISavingsRepository
    {
        Task<List<Saving>> GetAllSavingsAsync();
        Task<Saving?> GetByIdAsync(int id);
        Task<Saving> CreateSavingsAsync(Saving saving);
        Task<Saving?> UpdateSavingsAsync(int id, Saving saving);
        Task<bool> DeleteSavingsAsync(int id);
    }
}