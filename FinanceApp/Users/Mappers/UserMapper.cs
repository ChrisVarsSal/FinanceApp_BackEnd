using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinanceApp.Users.DTOs;
using UserEntity = FinanceApp.Users.Models.User;

namespace FinanceApp.Users.Mappers
{
    public static class UserMapper
    {
        public static UserDto ToUserDto(this UserEntity userModel)
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

        public static UserEntity ToUserFromCreateDto(this CreateUserRequestDto userDto)
        {
            return new UserEntity
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

        public static UserEntity ToUserFromUpdateDto(this UpdateUserRequestDto updateDto)
        {
            return new UserEntity
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