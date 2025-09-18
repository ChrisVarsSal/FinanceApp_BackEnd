using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.DTOs.Loan;
using FinanceApp.Models;

namespace FinanceApp.Mappers
{
    public static class LoanMapper
    {
        public static LoanDto ToLoanDto(this Loan loanModel)
        {
            return new LoanDto
            {
                Id = loanModel.Id,
                Name = loanModel.Name,
                Description = loanModel.Description,
                Amount = loanModel.Amount,
                InterestRate = loanModel.InterestRate,
                Status = loanModel.Status,
                MonthlyDeposit = loanModel.MonthlyDeposit,
                RequestedDate = loanModel.RequestedDate,

            };
        }

        public static Loan ToLoanFromCreateDto(this CreateLoanRequestDto loanDto)
        {
            return new Loan
            {
                Name = loanDto.Name,
                Description = loanDto.Description,
                Amount = loanDto.Amount,
                InterestRate = loanDto.InterestRate,
                Status = loanDto.Status,
                MonthlyDeposit = loanDto.MonthlyDeposit,
                RequestedDate = loanDto.RequestedDate,
            };
        }
    }
}
