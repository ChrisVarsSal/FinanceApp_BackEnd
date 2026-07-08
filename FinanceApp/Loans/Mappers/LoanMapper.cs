using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Loans.DTOs;
using UserEntity = FinanceApp.Loans.Models.Loan;

namespace FinanceApp.Loans.Mappers
{
    public static class LoanMapper
    {
        public static LoanDto ToLoanDto(this UserEntity loanModel)
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

        public static UserEntity ToLoanFromCreateDto(this CreateLoanRequestDto loanDto)
        {
            return new UserEntity
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
