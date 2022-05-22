using HackWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HackWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddReminderController : ControllerBase
    {
        private readonly AddReminderContext _thiscontext;
        private readonly IConfiguration _thisconfiguration;
        public AddReminderController(AddReminderContext addReminderContext, IConfiguration configuration)
        {
            _thiscontext = addReminderContext;
            _thisconfiguration = configuration;
        }

        [HttpPost]
        [Route("add")]
        public JsonResult Post(AddReminderModel model)
        {
            string query = @"
                INSERT INTO dbo.tblTickler(TickleBy, ContactID, TicklerTypeID, ObjectID, ObjectTypeID, TicklerDaysOut, TicklerFrequency,TicklerMessage, UserDefinedDate, isDeleted, LastModifiedBy, LastModified)
                VALUES(
                " + model.TickleBy + @",
                " + model.ContactID + @",
                " + model.TicklerTypeID + @",
                " + model.ObjectID + @",
                " + model.ObjectTypeID + @",
                " + model.TicklerDaysOut + @",
                " + model.TicklerFrequency + @",
                '" + model.TicklerMessage + @"',
                '" + model.UserDefinedDate + @"',
                '" + model.isDeleted + @"',
                " + model.LastModifiedBy + @",
                '" + model.LastModified + @"'
                )";
            DataTable table = new DataTable();
            string sqlDataSource = _thisconfiguration.GetConnectionString("AddReminder");
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
            return new JsonResult("Inserted a new reminder for  " + model.ObjectID + " successfully !");
        }
    }
}
