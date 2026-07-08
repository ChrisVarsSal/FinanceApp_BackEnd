using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserEntity = FinanceApp.Faqs.Models.Faq;

namespace FinanceApp.Faqs.Interfaces
{
    public interface IFaqRepository
    {
     Task<List<UserEntity>> GetAllFaqsAsync();
     Task<UserEntity?> GetByIdAsync(int id);  
    }
}