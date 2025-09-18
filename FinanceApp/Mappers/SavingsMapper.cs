using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.DTOs.Savings;
using FinanceApp.Models;

namespace FinanceApp.Mappers
{
    public static class SavingsMapper
    {
        public static SavingsDto ToLoanDto(this Saving savingsModel)
        {
            return new SavingsDto
            {
                Id = savingsModel.Id,
                Name = savingsModel.Name,
                Description = savingsModel.Description,
                Amount = savingsModel.Amount,
                InterestRate = savingsModel.InterestRate,
                InitialDeposit = savingsModel.InitialDeposit,
                MonthlyDeposit = savingsModel.MonthlyDeposit,
                RequestedDate = savingsModel.RequestedDate,

            };
        }

        public static Saving ToSavingFromCreateDto(this CreateSavingsRequestDto savingDto)
        {
            return new Saving
            {
                Name = savingDto.Name,
                Description = savingDto.Description,
                Amount = savingDto.Amount,
                InterestRate = savingDto.InterestRate,
                InitialDeposit = savingDto.InitialDeposit,
                MonthlyDeposit = savingDto.MonthlyDeposit,
                RequestedDate = savingDto.RequestedDate,
            };
        }
    }
}