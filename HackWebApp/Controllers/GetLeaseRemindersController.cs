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
    public class GetLeaseRemindersController : ControllerBase
    {
        private readonly GetLeaseRemindersContext _context;

        public GetLeaseRemindersController(GetLeaseRemindersContext LeaseReminders)
        {
            _context = LeaseReminders;
        }


        [HttpGet("reminders")]
        //GET: /api/Finanace
        public IActionResult GetLeaseReminderData()
        {
            var BuildingRemindersData = _context.getLeaseRemindersModel.AsQueryable();
            return Ok(BuildingRemindersData);
        }
    }
}
