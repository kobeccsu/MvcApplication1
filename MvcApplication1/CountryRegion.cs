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
    
    public partial class CountryRegion
    {
        public CountryRegion()
        {
            this.CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            this.SalesTerritory = new HashSet<SalesTerritory>();
            this.StateProvince = new HashSet<StateProvince>();
        }
    
        public string CountryRegionCode { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual ICollection<SalesTerritory> SalesTerritory { get; set; }
        public virtual ICollection<StateProvince> StateProvince { get; set; }
    }
}
