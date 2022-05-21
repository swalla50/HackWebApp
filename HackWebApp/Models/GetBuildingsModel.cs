using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingsModel
    {
        [Key]
        public int BuildingID { get; set; }
        public string BuildingName { get; set; }
        public int BuildingHierarchy { get; set; }
    }
}
