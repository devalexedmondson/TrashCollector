using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [ForiegnKey(State.ID)]
    
    }
}