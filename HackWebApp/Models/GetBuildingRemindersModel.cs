using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingRemindersModel
    {
        [Key]
        public int TickleID { get; set; }
        public int TicklerFreq { get; set; }
        public int ContactID { get; set; }
        public int TicklerTypeID { get; set; }
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }
        public DateTime startDate { get; set; }
        public bool isDeleted { get; set; }
    }
}
