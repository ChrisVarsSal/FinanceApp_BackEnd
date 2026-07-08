using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Faqs.Interfaces;
using FinanceApp.Faqs.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Faqs.Controllers
{
    [ApiController]
    [Route("FinanceApp/faq")]
    public class FaqController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly IFaqRepository _faqRepository;
        public FaqController(AppDBContext context, IFaqRepository faqRepository)
        {
            _context = context;
            _faqRepository = faqRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFaqs()
        {
            var faqs = await _faqRepository.GetAllFaqsAsync();
            var faqDto = faqs.Select(f => f.ToFaqDto());
            return Ok(faqs);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFaqById([FromRoute] int id)
        {
            var faq = await _faqRepository.GetByIdAsync(id);
            if (faq == null)
            {
                return NotFound();
            }
            return Ok(faq.ToFaqDto());
        }
    }
}