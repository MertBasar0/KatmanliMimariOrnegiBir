﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Order
    {
        public int OrderID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }

        public string CustomerID { get; set; }
    }
}
