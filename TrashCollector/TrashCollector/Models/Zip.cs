using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Zip
    {
        [Key]
        public int ZipID { get; set;}
        public int Zipcode { get; set;}
    }
}