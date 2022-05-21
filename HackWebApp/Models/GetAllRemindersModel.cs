using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetAllRemindersModel
    {
        [Key]
        public int? TickleID { get; set; }
        public int? ContactID { get; set; }
        public int? TicklerFreq { get; set; }
        public string? TickleDescription { get; set; }
        public int? TicklerTypeID { get; set; }
        public string? ContactName { get; set; }
        public string? TicklerMessage { get; set; }
        public DateTime? startDate { get; set; }
        public bool? isDeleted { get; set; }
        public int ObjectID { get; set; }
    }
}
