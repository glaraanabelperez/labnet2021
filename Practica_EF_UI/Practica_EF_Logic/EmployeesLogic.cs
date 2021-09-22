﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_EF_Entities;

namespace Practica_EF_Logic
{
    public class EmployeesLogic : BaseLogic
    {
        public List<Employees> GetAllEmployees()
        {
            return context.Employees.ToList();
        }
    }
}