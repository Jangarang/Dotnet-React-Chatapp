using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Message
{
    public class CreateMessageDto
    {
        public string Body { get; set; } = String.Empty;
        public int ConversationId { get; set; }
        public int SenderId { get; set; }
    }
}