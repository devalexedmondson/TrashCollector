using Microsoft.AspNet.Identity.EntityFramework;
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
        public int ID { get; set; }
        public int ZipID { get; set; }
        [ForeignKey("ZipID")]
        public Zip Zip_ID { get; set; }
    }
}