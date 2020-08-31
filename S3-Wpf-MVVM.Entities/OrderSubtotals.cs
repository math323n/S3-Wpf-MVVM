using System;
using System.Collections.Generic;

namespace S3_Wpf_MVVM.Entities
{
    public partial class OrderSubtotals
    {
        public int OrderID { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
