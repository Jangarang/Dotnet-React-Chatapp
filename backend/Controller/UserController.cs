using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using backend.Models;


//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controller
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        IActionResult GetAll()
        {
            var users = _context.Users.ToList(); //Deffered execution makes a list and sql query on the fly
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var user = _context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }
    
            return Ok(user);
        }

    }
}