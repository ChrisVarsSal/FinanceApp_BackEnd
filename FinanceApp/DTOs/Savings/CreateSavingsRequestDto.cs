using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.DTOs.Savings
{
    public class CreateSavingsRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal InterestRate { get; set; }
        public decimal InitialDeposit { get; set; }
        public decimal MonthlyDeposit { get; set; }
        public DateTime RequestedDate { get; set; } = DateTime.Now;

    }
}