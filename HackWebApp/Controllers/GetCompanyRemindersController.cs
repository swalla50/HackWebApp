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
    public class GetCompanyRemindersController : ControllerBase
    {
        private readonly GetCompanyRemindersContext _context;

        public GetCompanyRemindersController(GetCompanyRemindersContext CompanyReminders)
        {
            _context = CompanyReminders;
        }


        [HttpGet("reminders")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var CompanyRemindersData = _context.getCompanyReminderModels.AsQueryable();
            return Ok(CompanyRemindersData);
        }
    }
}
