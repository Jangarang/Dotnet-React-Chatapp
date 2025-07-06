using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Conversation
{
    public class ConversationDto
    {
        
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // References

        // public List<User> Participants { get; set; } = [];

        // public List<Message> Messages { get; set; } = [];
    }
}