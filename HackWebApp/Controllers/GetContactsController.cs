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
    public class GetContactsController : ControllerBase
    {
        private readonly GetContactsContext _context;

        public GetContactsController(GetContactsContext ContactList)
        {
            _context = ContactList;
        }


        [HttpGet("getcontactlist")]
        //GET: /api/Finanace
        public IActionResult GetFinData()
        {
            var contactData = _context.getContactsModels.AsQueryable();
            return Ok(contactData);
        }
    }
}
