using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetHierarchyModel
    {
        
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        [Key]
        public int CompanyHierarchyID { get; set; }
        public int CompanyHierarchyLabelID { get; set; }
        public int MasterGroupID { get; set; }
        public string CompanyHierarchyLabelDesc { get; set; }
    }
}
