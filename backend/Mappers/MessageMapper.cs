using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Message;
using backend.Models;

namespace backend.Mappers
{
    public static class MessageMapper
    {
        public static MessageDto ToMessageDto(this Message messageModel)
        {
            return new MessageDto
            {
                Id = messageModel.Id,
                Body = messageModel.Body,
                CreatedAt = messageModel.CreatedAt, 
                ConversastionId = messageModel.ConversastionId,
                SenderId = messageModel.SenderId,
            };
        } 
    }
}