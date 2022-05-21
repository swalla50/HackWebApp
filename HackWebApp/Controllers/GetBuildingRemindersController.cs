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
    public class GetBuildingRemindersController : ControllerBase
    {
        private readonly GetBuildingRemindersContext _context;

        public GetBuildingRemindersController(GetBuildingRemindersContext BuildingReminders)
        {
            _context = BuildingReminders;
        }


        [HttpGet("reminders")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var BuildingRemindersData = _context.getBuildinReminderModels.AsQueryable();
            return Ok(BuildingRemindersData);
        }
    }
}
