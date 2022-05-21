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
    public class GetBuildingandHierarchyController : ControllerBase
    {
        private readonly GetBuildingandHierarchyContext _context;

        public GetBuildingandHierarchyController(GetBuildingandHierarchyContext BuildingandHierarchy)
        {
            _context = BuildingandHierarchy;
        }


        [HttpGet("buildinghierarchy")]
        //GET: /api/Finanace
        public IActionResult GetBHData()
        {
            var AllBHData = _context.getBuildingandHierarchyModels.AsQueryable();
            return Ok(AllBHData);
        }
    }
}
