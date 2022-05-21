using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetCompanyRemindersModel
    {
        [Key]
        public int TickleID { get; set; }
        public int TicklerFreq { get; set; }
        public int ContactID { get; set; }
        public int CompanyID { get; set; }
        public string TicklerMessage { get; set; }
        public string CompanyName { get; set; }
        public DateTime startDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
