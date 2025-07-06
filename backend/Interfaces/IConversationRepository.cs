using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Interfaces
{
    public interface IConversationRepository
    {
        Task<List<Conversation>?> GetUsersConversationsAsync(int userId);
        Task<List<User>?> GetUserInConversationAsync(int conversationId);


    }
}