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
    public class CompanyController : ControllerBase
    {
        private readonly CompanyContext _context;

        public CompanyController(CompanyContext CompanyList)
        {
            _context = CompanyList;
        }


        [HttpGet("getcompany")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var companyListData = _context.getCompanyModels.AsQueryable();
            return Ok(companyListData);
        }
    }
}
