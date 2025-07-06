using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Conversation;
using backend.Models;

namespace backend.Mappers
{
    public static class ConversationMapper
    {
        public static ConversationDto ToConversationDto(this Conversation conversationModel)
        {
            return new ConversationDto
            {
                Id = conversationModel.Id,
                CreatedAt = conversationModel.CreatedAt,
                UpdatedAt = conversationModel.UpdatedAt
            };
        }
        public static Conversation ToConversationFromCreateConversationDTO(this CreateConversationRequestDto conversationDto) 
        {
            return new Conversation
            {
                CreatedAt = conversationDto.CreatedAt,
                UpdatedAt = conversationDto.UpdatedAt,
            };
        }
    }
}