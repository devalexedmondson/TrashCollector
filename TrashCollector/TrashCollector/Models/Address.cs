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
        public virtual State StateName { get; set; }
        public virtual City CityName { get; set; }
        public virtual Zip Zip { get; set; }

    }
}