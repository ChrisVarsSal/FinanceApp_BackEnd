using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using Microsoft.AspNetCore.Mvc;
using FinanceApp.Savings.DTOs;
using FinanceApp.Savings.Interfaces;
using FinanceApp.Savings.Mappers;

namespace FinanceApp.Savings.Controller
{
    [ApiController]
    [Route("FinanceApp/savings")]
    public class SavingsController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly ISavingsRepository _savingsRepository;
        public SavingsController(AppDBContext context, ISavingsRepository savingsRepository)
        {
            _context = context;
            _savingsRepository = savingsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSavings()
        {
            var savings = await _savingsRepository.GetAllSavingsAsync();
            var savingsDto = savings.Select(u => u.ToSavingsDto());
            return Ok(savings);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSavingsById([FromRoute] int id)
        {
            var savings=await _savingsRepository.GetByIdAsync(id);
            if (savings == null)
            {
                return NotFound();
            }
            return Ok(savings.ToSavingsDto());
        }
        [HttpPost]
        public async Task<IActionResult> CreateSavings([FromBody] CreateSavingsRequestDto savingsDto)
        {
            var savingsModel=savingsDto.ToSavingsFromCreateDto();
            var createSavings=await _savingsRepository.CreateSavingsAsync(savingsModel);
            return CreatedAtAction(nameof(GetSavingsById),new{id=createSavings.Id},createSavings.ToSavingsDto());
        } 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSavings([FromRoute] int id,[FromBody] UpdateSavingsRequestDto updateDto)
        {
            var savingsModel=updateDto.ToSavingsFromUpdateDto();
            var updatedSavings=await _savingsRepository.UpdateSavingsAsync(id,savingsModel);
            if(updatedSavings==null)
            {
                return NotFound();
            }
            return Ok(updatedSavings.ToSavingsDto());
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSavings([FromRoute] int id)
        {
            var savingsDeleted=await _savingsRepository.DeleteSavingsAsync(id);
            if(!savingsDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
     }
}