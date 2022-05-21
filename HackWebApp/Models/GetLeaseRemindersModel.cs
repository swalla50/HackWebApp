using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetLeaseRemindersModel
    {
        [Key]
        public int ReminderID { get; set; }
        public int ReminderFreq { get; set; }
        public string ReminderMessage { get; set; }
        public int ContactID { get; set; }
        public int ReminderTypeID { get; set; }
        public int ObjectID { get; set; }
        public int TicklerTypeID { get; set; }
        public bool isDeleted { get; set; }
    }
}
