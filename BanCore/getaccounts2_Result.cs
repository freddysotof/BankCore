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
    
    public partial class getaccounts2_Result
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Number { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> AccountTypeId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<System.DateTime> LastTransaction { get; set; }
        public Nullable<int> AccountManagerId { get; set; }
        public Nullable<int> CurrencyTypeId { get; set; }
        public Nullable<int> StatusId { get; set; }
        public Nullable<double> Balance { get; set; }
        public Nullable<double> YesterdayBalance { get; set; }
    }
}
