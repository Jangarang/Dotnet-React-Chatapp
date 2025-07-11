using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.AspNetCore.SignalR;

namespace backend.Chathub
{
    public class Chathub : Hub
    {
        private readonly ApplicationDBContext _db;

        public Chathub(ApplicationDBContext db)
        {
            _db = db;
        }

        

    }
}