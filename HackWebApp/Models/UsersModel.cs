using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class UsersModel
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactUserID { get; set; }
        public string ContactPassword { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string? ContactMiddleName { get; set; }
        public string? ContactSuffix { get; set; }
        public string? ContactDepartment { get; set; }
        public string? ContactTitle { get; set; }
        public string? ContactEmailAddress { get; set; }
        public int? CompanyID { get; set; }
    }
}
