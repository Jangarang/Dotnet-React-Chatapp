using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
    public class ConversationRepository : IConversationRepository
    {

        private ApplicationDBContext _context;
        //Dependency Injection
        public ConversationRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"> User ID </param>
        /// <returns> List of Conversations </returns>
        public async Task<List<Conversation>?> GetUsersConversationsAsync(int userId)
        {
            var conversations = await _context.Users
                .Include(u => u.Conversations)
                .Where(u => u.Id == userId)
                .SelectMany(u => u.Conversations)
                .ToListAsync();

            return conversations;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"> Conversation ID </param>
        /// <returns> List of Users </returns>
        public async Task<List<User>?> GetUserInConversationAsync(int conversationId)
        {
            var users = await _context.Conversations
                .Include(c => c.Participants)
                .Where(c => c.Id == conversationId)
                .SelectMany(c => c.Participants)
                .ToListAsync();
            return users;
        }
        
    }
}