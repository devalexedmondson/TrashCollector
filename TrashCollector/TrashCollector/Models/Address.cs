using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }

        public int StateID { get; set; }
        [ForeignKey("StateID")]
        public State StateName { get; set; }

        public int CityID { get; set; }
        [ForeignKey("CityID")]
        public City CityName { get; set; }

        public int ZipID { get; set; }
        [ForeignKey("ZipID")]
        public Zip Zip { get; set; }

    }
}