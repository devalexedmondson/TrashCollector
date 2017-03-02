using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public Address Address_ID { get; set; }
        public virtual Pick_Up_Options PickUpOptionsID { get; set; }
    }
}