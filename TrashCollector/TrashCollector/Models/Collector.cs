﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Collector
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Zip Zip_ID { get; set; }
    }
}