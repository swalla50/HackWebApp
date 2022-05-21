using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class CompanyModel
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
    }
}
