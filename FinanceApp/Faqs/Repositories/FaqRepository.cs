using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Faqs.Interfaces;
using UserEntity = FinanceApp.Faqs.Models.Faq;
using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Faqs.Repositories
{
    public class FaqRepository : IFaqRepository
    {
        private readonly AppDBContext _context;
        public FaqRepository(AppDBContext context)
        {
            _context=context;
        }

        public async Task<List<UserEntity>> GetAllFaqsAsync()
        {
            return await _context.Faq.ToListAsync();
        }

        public async Task<UserEntity?> GetByIdAsync(int id)
        {
            return await _context.Faq.FindAsync(id);
        }

        Task<List<UserEntity>> IFaqRepository.GetAllFaqsAsync()
        {
            throw new NotImplementedException();
        }

        Task<UserEntity?> IFaqRepository.GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}