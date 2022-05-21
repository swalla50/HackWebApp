using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class AddReminderModel
    {
        [Key]
        public int TickleID { get; set; }
        public int TickleBy { get; set; }
        public int ContactID { get; set; }
        public int TicklerTypeID { get; set; }
        public int ObjectID { get; set; }
        public int TicklerDaysOut { get; set; }
        public int TicklerFrequency { get; set; }
        public int TicklerMesage { get; set; }
        public DateTime UserDefinedDate { get; set; }
        public int ObjectTypeID { get; set; }
        public bool isDeleted { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; }
    }
}
