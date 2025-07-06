using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos.Message;
using backend.Models;

namespace backend.Interfaces
{
    public interface IMessageRepository
    {
        Task<List<Message>?> GetMessagesInConversation(int conversationId);

        Task CreateMessageAsync(Message message);

        //Testing purposes
        // Task<List<Message>> GetAll();
    }
}