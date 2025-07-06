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
        //That this Message message is the magic. It tells C#:

        //“Hey, treat this method like it belongs to the Message class — so it can be called with dot notation like m.ToMessageDto().”
        public static MessageDto ToMessageDto(this Message messageModel)
        {
            //Left out the navigation back references
            return new MessageDto
            {
                Id = messageModel.Id,
                Body = messageModel.Body,
                CreatedAt = messageModel.CreatedAt,
                ConversastionId = messageModel.ConversationId,
                SenderId = messageModel.SenderId,
            };
        }

        public static Message ToMessageFromCreateDto(this CreateMessageDto messageModel, int conversationId)
        {
            return new Message
            {
                Body = messageModel.Body,
                CreatedAt = DateTime.UtcNow,
                ConversationId = conversationId,
                SenderId = messageModel.SenderId,
            };
        } 
    }
}