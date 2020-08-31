using System;
using System.Collections.Generic;

namespace S3_Wpf_MVVM.Entities
{
    public partial class Products_by_Category
    {
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
