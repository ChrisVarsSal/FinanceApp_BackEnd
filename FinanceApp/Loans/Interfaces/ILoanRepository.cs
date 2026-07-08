using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserEntity = FinanceApp.Loans.Models.Loan;
using FinanceApp.Loans.Models;
using FinanceApp.Loans.Interfaces;

namespace FinanceApp.Loans.Interfaces
{
    public interface ILoanRepository
    {
        Task<List<UserEntity>> GetAllLoansAsync();
        Task<UserEntity> CreateLoanAsync(UserEntity loan);
        Task<UserEntity?> UpdateLoanAsync(int id, UserEntity loan);
        Task<bool> DeleteLoanAsync(int id);
    }
}