using HackWebApp.Models;
using Microsoft.AspNetCore.Authorization;
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
    public class GetHierarchyController : ControllerBase
    {
        private readonly GetHierarchyContext _context;

        public GetHierarchyController(GetHierarchyContext HierarchyFeed)
        {
            _context = HierarchyFeed;
        }


        [HttpGet("gethierarchydata")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var hierarchyData = _context.getHierarchyModels.AsQueryable();
            return Ok(hierarchyData);
        }
    }
}
