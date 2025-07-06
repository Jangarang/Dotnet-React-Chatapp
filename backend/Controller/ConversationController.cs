using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Dtos.Conversation;
using backend.Dtos.User;
using backend.Interfaces;
using backend.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controller
{
    // [Route("api/conversations")]
    [ApiController]
    public class ConversationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        private readonly IConversationRepository _conversationRepo;

        public ConversationController(ApplicationDBContext context, IConversationRepository conversationRepo)
        {
            _conversationRepo = conversationRepo;
            _context = context;
        }

        [HttpGet("api/user/{userId}/conversations")]
        public async Task<IActionResult> GetUsersConversations([FromRoute] int userId)
        // public IActionResult GetAll()
        {
            var conversations = await _conversationRepo.GetUsersConversationsAsync(userId);

            if (conversations != null)
            {

                var conversationDto = conversations.Select(s => s.ToConversationDto());
            }
        
            return Ok(conversations);
        }

        // //Do I need this?
        // [HttpGet("")]
        // public IActionResult GetById([FromRoute] int id)
        // {
        //     var conversation = _context.Conversations.Find(id);

        //     if (conversation == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(conversation);
        // }

        [HttpGet("api/conversations/{conversationId}/users")]
        public async Task<IActionResult> GetUsersById([FromRoute] int conversationId)
        {
            var users = await _conversationRepo.GetUserInConversationAsync(conversationId);

            if (users == null)
            {
                return NotFound("Conversation not found");
            }

            var userDtos = users.Select(u => new UserInConversationDto
            {
                Id = u.Id,
                Username = u.Username,
                FullName = u.FullName,
                Gender = u.Gender,
                ProfilePic = u.ProfilePic,
            }).ToList();

            return Ok(userDtos);
        }

        // [HttpPost]

        // //Do I need this?
        // public IActionResult Create([FromBody] CreateConversationRequestDto conversationDto)
        // {
        //     var conversationModel = conversationDto.ToConversationFromCreateConversationDTO();
        //     _context.Conversations.Add(conversationModel);
        //     _context.SaveChanges();
        //     return CreatedAtAction(nameof(GetById), new { id = conversationModel.Id }, conversationModel.ToConversationDto());
        // }

       
    }
}