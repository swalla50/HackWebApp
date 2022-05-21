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
    public class GetBuildingsController : ControllerBase
    {
        private readonly GetBuildingsContext _context;

        public GetBuildingsController(GetBuildingsContext AllBuildings)
        {
            _context = AllBuildings;
        }


        [HttpGet("buildings")]
        //GET: /api/Finanace
        public IActionResult GetBuildingData()
        {
            var AllBuildingsData = _context.getBuildingsModels.AsQueryable();
            return Ok(AllBuildingsData);
        }
    }
}
