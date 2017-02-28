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
        public virtual Time Normal { get; set; }
        public virtual Time Substitute { get; set; }
        public virtual Time Absent { get; set; }
    }
}