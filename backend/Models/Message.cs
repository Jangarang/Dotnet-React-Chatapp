using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
    public class Message
    {
        public int Id { get; set; }

        public string Body { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; } 

        // References
        // Maybe make these nullable first?

        public int? ConversationId { get; set; } // Foreign key

        public int? SenderId { get; set; } // Foreign key

        public Conversation Conversation { get; set; } = null!; // Navigation back

        public User Sender { get; set; } = null!;
    }
}