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
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        [ForeignKey("State")]
        public int StateID { get; set; }
        public virtual State State { get; set; }
        [ForeignKey("City")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
        [ForeignKey("Zip")]
        public int ZipID { get; set; }
        public virtual Zip Zip { get; set; }

    }
}