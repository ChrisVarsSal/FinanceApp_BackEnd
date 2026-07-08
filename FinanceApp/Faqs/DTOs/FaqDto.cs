using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceApp.Faqs.DTOs
{
    public class FaqDto
    {
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
        public int Category { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}