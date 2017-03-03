using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Pick_Up_Options
    {
        [Key]
        public int ID { get; set; }
        public int TimeID { get; set; }

        [ForeignKey("TimeID")]
        public Time Normal { get; set; }
    }
}