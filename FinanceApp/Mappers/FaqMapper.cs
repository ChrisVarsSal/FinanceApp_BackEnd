using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.DTOs.Faq;
using FinanceApp.Models;

namespace FinanceApp.Mappers
{
    public static class FaqMapper
    {
        public static FaqDto ToFaqDto(Faq faq)
        {
            return new FaqDto
            {
                Id = faq.Id,
                Question = faq.Question,
                Answer = faq.Answer,
                Category = faq.Category,
                CreatedAt = faq.CreatedAt
            };
        }
    }
}