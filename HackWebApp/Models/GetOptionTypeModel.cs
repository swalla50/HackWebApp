using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetOptionTypeModel
    {
        [Key]
        public int TicklerTypeID { get; set; }
        public string TickleModule { get; set; }
        public string? TickleDescription { get; set; }
        public string? StandardMessage { get; set; }
        public string? TickleFieldName { get; set; }
        public string? TickleTableName { get; set; }
        public string? TickleJoinFieldName { get; set; }
        public bool? TickleDynamic { get; set; }
        public DateTime? LastModified { get; set; }
    }
}

