using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Time
    {
        [Key]
        public int TimeID { get; set; }
        public string Day { get; set; }
        public string Time_Of_Day { get; set; }
    }
}