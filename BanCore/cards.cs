//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class cards
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Number { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> CutOffDate { get; set; }
        public Nullable<System.DateTime> PaymentLimitDate { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<double> Limit { get; set; }
        public Nullable<int> CurrencyTypes { get; set; }
        public Nullable<double> Balance { get; set; }
    }
}
