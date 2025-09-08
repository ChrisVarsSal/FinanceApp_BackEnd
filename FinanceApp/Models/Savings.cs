using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Models
{
    public class Saving
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal InterestRate { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal InitialDeposit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyDeposit { get; set; }
        public DateTime RequestedDate { get; set; } = DateTime.Now;
        public int? UserId { get; set; }
        public User? User { get; set; }
    }
}