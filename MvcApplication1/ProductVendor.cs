//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductVendor
    {
        public int ProductID { get; set; }
        public int BusinessEntityID { get; set; }
        public int AverageLeadTime { get; set; }
        public decimal StandardPrice { get; set; }
        public Nullable<decimal> LastReceiptCost { get; set; }
        public Nullable<System.DateTime> LastReceiptDate { get; set; }
        public int MinOrderQty { get; set; }
        public int MaxOrderQty { get; set; }
        public Nullable<int> OnOrderQty { get; set; }
        public string UnitMeasureCode { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual UnitMeasure UnitMeasure { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
