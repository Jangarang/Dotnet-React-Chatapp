using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.User;
using backend.Models;

namespace backend.Mappers
{
    public static class UserMapper
    {
        public static UserInConversationDto ToUserDto(this User userModel)
        {
            return new UserInConversationDto
            {   
                Id = userModel.Id,
                Username = userModel.Username,
                FullName = userModel.FullName,
                Gender = userModel.Gender,
                ProfilePic = userModel.ProfilePic,
            };
        }
    }
}