﻿using System;
using System.Collections.Generic;

namespace S3_Wpf_MVVM.Entities
{
    public partial class Summary_of_Sales_by_Quarter
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
