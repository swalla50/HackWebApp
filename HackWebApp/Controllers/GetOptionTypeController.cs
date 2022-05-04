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
    public class GetOptionTypeController : ControllerBase
    {
        private readonly GetOptionTypeContext _context;

        public GetOptionTypeController(GetOptionTypeContext OptionTypeFeed)
        {
            _context = OptionTypeFeed;
        }


        [HttpGet("getoptiontypedata")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var OptionTypeData = _context.getOptionTypeModels.AsQueryable();
            return Ok(OptionTypeData);
        }
    }
}
