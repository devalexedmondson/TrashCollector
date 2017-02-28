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
        public int Pick_Up_OptionsID { get; set; }
        [ForeignKey("Zip")]
        public int TimeID { get; set; }
        public virtual Time Day { get; set; }
    }
}