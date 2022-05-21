using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetBuildingandHierarchyModel
    {
       
        public int CompanyHierarchyID { get; set; }
        public int CompanyID { get; set; } 
        
        public int BuildingID { get; set; }
        public string Hierarchy { get; set; }
        public string CompanyHierarchyLabelDesc { get; set; }
        public string BuildingName { get; set; }
        public string CompanyName { get; set; }

    }
}
