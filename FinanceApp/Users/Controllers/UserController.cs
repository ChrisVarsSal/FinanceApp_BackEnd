using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Data;
using FinanceApp.Users.DTOs;
using FinanceApp.Users.Interfaces;
using FinanceApp.Users.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Users.Controller
{
    [ApiController]
    [Route("FinanceApp/user")]
    public class UserController : ControllerBase
    {
        private readonly AppDBContext _context;
        private readonly IUserRepository _userRepository;
        public UserController(AppDBContext context, IUserRepository userRepository)
        {
            _context = context;
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsersAsync();
            var userDto = users.Select(u => u.ToUserDto());
            return Ok(users);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user.ToUserDto());
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDto userDto)
        {
            var userModel = userDto.ToUserFromCreateDto();
            var createUser = await _userRepository.CreateUserAsync(userModel);
            return CreatedAtAction(nameof(GetUserById), new { id = createUser.Id }, createUser.ToUserDto());
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] UpdateUserRequestDto updateDto)
        {
            var userModel = updateDto.ToUserFromUpdateDto();
            var updatedUser = await _userRepository.UpdateUserAsync(id, userModel);
            if (updatedUser == null)
            {
                return NotFound();
            }
            return Ok(updatedUser.ToUserDto());
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var userDeleted = await _userRepository.DeleteUserAsync(id);
            if (!userDeleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}