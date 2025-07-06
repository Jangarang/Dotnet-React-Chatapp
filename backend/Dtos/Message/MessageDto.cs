using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Dtos.Message
{
    public class MessageDto
    {
        public int Id { get; set; }

        public string Body { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; } 

        public int? ConversastionId { get; set; }

        public int? SenderId { get; set; }

    }
}