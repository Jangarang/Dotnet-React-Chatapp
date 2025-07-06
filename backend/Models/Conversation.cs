using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Conversation
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // References

        public List<User> Participants { get; set; } = []; //Many to many

        public List<Message> Messages { get; set; } = []; // navigation property
    }
}