using HackWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllRemindersController : ControllerBase
    {
        private readonly GetAllRemindersContext _context;

        public GetAllRemindersController(GetAllRemindersContext AllReminders)
        {
            _context = AllReminders;
        }


        [HttpGet("reminders")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var AllRemindersData = _context.getAllReminderModels.AsQueryable();
            return Ok(AllRemindersData);
        }
    }
}
