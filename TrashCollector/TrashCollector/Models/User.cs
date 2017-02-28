using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TrashCollector.Models
{
    public class User
    {
        [Key]
        public int ID { get; set;}
        public string Name { get; set;}
        public MailAddress Email { get; set;}
        public string Password { get; set;}
        public double Amount_Due { get; set;}
        public int Type { get; set;}
        public virtual Address AddressID { get; set;}
        public virtual Pick_Up_Options Pick_Up_OptionsID { get; set;}
    }
}