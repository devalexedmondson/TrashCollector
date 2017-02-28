using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class User
    {
        [Key]
        public int ID { get; set;}
        public string Name { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
        public float Amount_Due { get; set;}
        public int Type { get; set;}
        [ForeignKey("")]
        public int Address { get; set;}
        []
        public int Pick_Up_Options { get; set;}

 
    }
}