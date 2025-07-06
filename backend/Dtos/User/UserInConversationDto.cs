using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.User
{
    //[Entity][Context]Dto convention
    public class UserInConversationDto
    {
        public int Id { get; set; }

        public string Username { get; set; } = String.Empty;

        public string FullName { get; set; } = String.Empty;

        public string Gender { get; set; } = String.Empty;

        public string ProfilePic { get; set; } = String.Empty;

    }
}