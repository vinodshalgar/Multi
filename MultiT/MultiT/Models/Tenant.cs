﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiT.Models
{
    public class Tenant
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string DomainName { get; set; }
        public bool Default { get; set; }
    }
}