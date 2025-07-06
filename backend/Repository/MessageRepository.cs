using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class MessageRepository : IMessageRepository
    {

        private readonly ApplicationDBContext _context;
        public MessageRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Message>> GetMessagesInConversation(int conversationId)
        {
            var messages = await _context.Messages
                .Where(m => m.ConversastionId == conversationId)
                .OrderBy(m => m.CreatedAt)
                .ToListAsync();

            return messages;
        }
    }
}