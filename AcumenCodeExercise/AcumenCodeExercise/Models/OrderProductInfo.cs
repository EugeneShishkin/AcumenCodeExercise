﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcumenCodeExercise.Models
{
    public class OrderProductInfo
    {
        public int OrderID { get; set; }

        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }
    }
}