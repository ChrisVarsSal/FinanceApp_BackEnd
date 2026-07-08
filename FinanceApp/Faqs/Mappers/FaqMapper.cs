using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Faqs.DTOs;
using UserEntity = FinanceApp.Faqs.Models.Faq;

namespace FinanceApp.Faqs.Mappers
{
    public static class FaqMapper
    {
        public static FaqDto ToFaqDto(this UserEntity faqModel)
        {
            return new FaqDto
            {
                Id = faqModel.Id,
                Question = faqModel.Question,
                Answer = faqModel.Answer,
                Category = faqModel.Category,
                CreatedAt = faqModel.CreatedAt
            };
        }
    }
}