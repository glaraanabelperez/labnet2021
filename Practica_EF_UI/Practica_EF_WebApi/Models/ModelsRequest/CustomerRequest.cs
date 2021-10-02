﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practica_EF_Entities;

namespace Practica_EF_Api.Models.ModelsRequest
{
    public class CustomerRequest
    {
        public string CustomerID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string Country { get; set; }

    }
}