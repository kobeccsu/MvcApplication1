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
    
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            this.SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }
    
        public int SpecialOfferID { get; set; }
        public int ProductID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
