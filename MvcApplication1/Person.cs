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
    
    public partial class Person
    {
        public Person()
        {
            this.BusinessEntityContact = new HashSet<BusinessEntityContact>();
            this.EmailAddress = new HashSet<EmailAddress>();
            this.Customer = new HashSet<Customer>();
            this.PersonCreditCard = new HashSet<PersonCreditCard>();
            this.PersonPhone = new HashSet<PersonPhone>();
        }
    
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public int EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        public string Demographics { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
