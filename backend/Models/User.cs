using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        public string Username { get; set; } = String.Empty;

        public string FullName { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;

        public string ProfilePic { get; set; } = String.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        //References        

        public List<Conversation> Conversations { get; set; } = []; // Many to many
        public List<Message> Messages { get; set; } = [];

    }
}