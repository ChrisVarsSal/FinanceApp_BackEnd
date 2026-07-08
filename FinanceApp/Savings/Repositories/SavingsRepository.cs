using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Savings.Interfaces;
using FinanceApp.Savings.Models;
using FinanceApp.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Savings.Repositories
{
    public class SavingsRepository : ISavingsRepository
    {
        private readonly AppDBContext _context;
        public SavingsRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<Saving> CreateSavingsAsync(Saving saving)
        {
            await _context.Saving.AddAsync(saving);
            await _context.SaveChangesAsync();
            return saving;
        }
        public async Task<bool> DeleteSavingsAsync(int id)
        {
            var savingModel = await _context.Saving.FirstOrDefaultAsync(x => x.Id == id);
            if (savingModel == null)
            {
                return false;
            }
            _context.Saving.Remove(savingModel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Saving?> UpdateSavingsAsync(int id, Saving updateSaving)
        {
            var savingModel = await _context.Saving.FirstOrDefaultAsync(x => x.Id == id);
            if (savingModel == null)
            {
                return null;
            }
            savingModel.Name = updateSaving.Name;
            savingModel.Description = updateSaving.Description;
            savingModel.Amount = updateSaving.Amount;
            savingModel.InterestRate = updateSaving.InterestRate;
            savingModel.InitialDeposit = updateSaving.InitialDeposit;
            savingModel.MonthlyDeposit = updateSaving.MonthlyDeposit;
            await _context.SaveChangesAsync();
            return savingModel;
        }
        public async Task<List<Saving>> GetAllSavingsAsync()
        {
            return await _context.Saving.ToListAsync();
        }

        public async Task<Saving?> GetByIdAsync(int id)
        {
            return await _context.Saving.FindAsync(id); 
        }
    }
}
