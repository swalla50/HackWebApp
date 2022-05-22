using System;
using System.ComponentModel.DataAnnotations;

namespace HackWebApp.Models
{
    public class inputModel
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
