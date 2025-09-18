using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.DTOs.User;
using FinanceApp.Models;

namespace FinanceApp.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this User userModel)
        {
            return new UserDto
            {
                Id = userModel.Id,
                Name = userModel.Name,
                LastName = userModel.LastName,
                Email = userModel.Email,
                Address = userModel.Address,
                PhoneNumber = userModel.PhoneNumber
            };
        }

        public static User ToUserModel(this CreateUserRequestDto userDto)
        {
            return new User
            {
                Id = userDto.Id,
                Name = userDto.Name,
                LastName = userDto.LastName,
                Email = userDto.Email,
                Password = userDto.Password,
                ConfirmPassword = userDto.ConfirmPassword,
                Address = userDto.Address,
                PhoneNumber = userDto.PhoneNumber
            };
        }

        public static User ToUserFromUpdateDto(this UpdateUserRequestDto updateDto)
        {
            return new User
            {
                Name = updateDto.Name,
                LastName = updateDto.LastName,
                Email = updateDto.Email,
                Password = updateDto.Password,
                ConfirmPassword = updateDto.ConfirmPassword,
                Address = updateDto.Address,
                PhoneNumber = updateDto.PhoneNumber
            };
        }
    }
}