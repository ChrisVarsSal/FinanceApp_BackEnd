using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Models;

namespace FinanceApp.Interfaces
{
    public interface IFaqRepository
    {
     Task<List<Faq>> GetAllFaqsAsync();
     Task<Faq?> GetByIdAsync(int id);  
    }
}