//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    
    public partial class NewResrvation_Result
    {
        public string ReceptionName { get; set; }
        public Nullable<System.DateTime> ReceptionDate { get; set; }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public Nullable<bool> IsValid { get; set; }
        public Nullable<int> ReceptionId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
