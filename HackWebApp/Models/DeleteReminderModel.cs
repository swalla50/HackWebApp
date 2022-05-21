using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class DeleteReminderModel
    {
        [Key]
        public int TickleID { get; set; }
        public bool isDeleted { get; set; }
    }
}
