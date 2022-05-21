using HackWebApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteReminderController : ControllerBase
    {
        private readonly DeleteReminderContext _thiscontext;
        private readonly IConfiguration _thisconfiguration;

        public DeleteReminderController(DeleteReminderContext DeleteReminderDbContext, IConfiguration configuration)
        {
            _thiscontext = DeleteReminderDbContext;
            _thisconfiguration = configuration;
        }
        [HttpPut]
        [Route("delete")]
        public JsonResult Put(DeleteReminderModel model)
        {
            string query = @"
                update dbo.tblTickler set
                isDeleted  = '" + model.isDeleted + @"'
                where TickleID =" + model.TickleID + @"
                ";
            DataTable table = new DataTable();
            string sqlDataSource = _thisconfiguration.GetConnectionString("DeleteReminder");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Reminder ID: "+ model.TickleID + "updated successfully !");
        }
    }
}
