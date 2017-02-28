﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TrashCollector.Models
{
    public class Collector
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public MailAddress Email { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
        public string Work_Day { get; set; }
        public virtual Client Client { get; set; }
        public virtual Zip Zip { get; set; }
    }
}