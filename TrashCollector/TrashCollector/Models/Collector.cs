using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Collector
    {
        [Key]
        public int CollectorID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public string Work_Day { get; set; }
        [ForeignKey("Client")]
        public int ClientsID { get; set; }
        public virtual Client Client { get; set; }
        [ForeignKey("Zip")]
        public int ZipID { get; set; }
        public virtual Zip Zip { get; set; }
    }
}