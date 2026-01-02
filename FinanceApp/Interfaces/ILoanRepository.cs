using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Models;

namespace FinanceApp.Interfaces
{
    public interface ILoanRepository
    {
        Task<List<Loan>> GetAllLoansAsync();
        Task<User?> GetByIdAsync(int id);
        Task<Loan> CreateLoanAsync(Loan loan);
        Task<Loan?> UpdateLoanAsync(int id, Loan loan);
        Task<bool> DeleteLoanAsync(int id);
    }
}