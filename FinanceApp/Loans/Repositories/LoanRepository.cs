using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Loans.Interfaces;
using UserEntity = FinanceApp.Loans.Models.Loan;
using Microsoft.EntityFrameworkCore;


namespace FinanceApp.Loans.Repository
{
    public class LoanRepository : ILoanRepository
    {
        private readonly AppDBContext _context;
        public LoanRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<UserEntity> CreateLoanAsync(UserEntity loan)
        {
            await _context.Loan.AddAsync(loan);
            await _context.SaveChangesAsync();
            return loan;
        }

        public async Task<bool> DeleteLoanAsync(int id)
        {
            var loanModel = await _context.Loan.FirstOrDefaultAsync(x => x.Id == id);
            if (loanModel == null)
            {
                return false;
            }
            _context.Loan.Remove(loanModel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<UserEntity?> UpdateLoanAsync(int id, UserEntity updateLoan)
        {
            var loanModel = await _context.Loan.FirstOrDefaultAsync(x => x.Id == id);
            if (loanModel == null)
            {
                return null;
            }
            loanModel.Name = updateLoan.Name;
            loanModel.Description = updateLoan.Description;
            loanModel.Amount = updateLoan.Amount;
            loanModel.InterestRate = updateLoan.InterestRate;
            loanModel.Status = updateLoan.Status;
            loanModel.MonthlyDeposit = updateLoan.MonthlyDeposit;
            loanModel.RequestedDate = updateLoan.RequestedDate;
            await _context.SaveChangesAsync();
            return loanModel;
        }
        public async Task<List<UserEntity>> GetAllLoansAsync()
        {
            return await _context.Loan.ToListAsync();
        }      
    }
}