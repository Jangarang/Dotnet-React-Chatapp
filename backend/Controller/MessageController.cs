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
        public async Task<IActionResult> GetMessagesInConversation([FromRoute] int conversationId)
        {
            var messages = await _messageRepo.GetMessagesInConversation(conversationId);

            if (messages == null)
            {
                return NotFound("Messages not found");
            }
            ;
            var messageDtos = messages.Select(m => m.ToMessageDto());

            return Ok(messageDtos);
        }

        [HttpPost("api/conversations/{conversationId}/messages")]
        public async Task<IActionResult> SendMessageInConversation(
            [FromRoute] int conversationId,
            [FromBody] CreateMessageDto messageDto)
        {
            var message = messageDto.ToMessageFromCreateDto(conversationId); //How did the 'this' automatically pass it in as function?

            await _messageRepo.CreateMessageAsync(message);

            return Ok();
        }
     

    }
}