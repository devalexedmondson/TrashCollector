﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public virtual User UserID { get; set; }
    }
}