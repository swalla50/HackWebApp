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
    public class ContactsController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get() => new string[]
        {
            "John Doe",
            "Jane Doe"
        };

    }
}
