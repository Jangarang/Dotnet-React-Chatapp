using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Message;
using backend.Interfaces;
using backend.Mappers;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    // [Route("api/messages")]
    public class MessageController : ControllerBase
    {
        private readonly IMessageRepository _messageRepo;

        public MessageController(IMessageRepository messageRepo)
        {
            _messageRepo = messageRepo;
        }

        [HttpGet("/api/conversations/{conversationId}/messages")]
        public async Task<IActionResult> GetMessagesInConversation(int conversationId)
        {
            var messages = await _messageRepo.GetMessagesInConversation(conversationId);

            if (messages == null)
            {
                return NotFound("Messages not found");
            }
            ;

            var messageDtos = messages.Select(m => new MessageDto
            {
                Id = m.Id,
                Body = m.Body,
                CreatedAt = m.CreatedAt,
                ConversastionId = m.ConversastionId,
                SenderId = m.SenderId,
            });

            return Ok(messageDtos);
        }




        // [HttpGet]
        // public async Task<IActionResult> GetAll()
        // {
        //     var messages = await _messageRepo.GetAllAsync();

        //     var messageDto = messages.Select(s => s.ToMessageDto());

        //     return Ok(messageDto);
        // }


    }
}