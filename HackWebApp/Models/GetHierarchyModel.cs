﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HackWebApp.Models
{
    public class GetHierarchyModel
    {
        [Key]
        public string Hierarchy { get; set; }
    }
}
