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

        public async Task CreateMessageAsync(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Message>?> GetMessagesInConversation(int conversationId)
        {
            var messages = await _context.Messages
                // .Include(m => m.Sender) // optional: if you want sender details
                .Where(m => m.ConversationId == conversationId)
                .OrderBy(m => m.CreatedAt)
                .ToListAsync();


            return messages;
        }

        // public async Task<List<Message>> GetAll()
        // { 
            
        // }
    }
}