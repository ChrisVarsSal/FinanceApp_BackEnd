using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Interfaces;
using FinanceApp.Models;
using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp.Repository
{
    public class FaqRepository : IFaqRepository
    {
        private readonly AppDBContext _context;
        public FaqRepository(AppDBContext context)
        {
            _context=context;
        }

        public async Task<List<Faq>> GetAllFaqsAsync()
        {
            return await _context.Faq.ToListAsync();
        }

        public async Task<Faq?> GetByIdAsync(int id)
        {
            return await _context.Faq.FindAsync(id);
        }
    }
}