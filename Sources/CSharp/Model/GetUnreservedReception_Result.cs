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
    
    public partial class GetUnreservedReception_Result
    {
        public string Name { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime BookingClosingDate { get; set; }
        public int Capacity { get; set; }
        public int SeatsPerTable { get; set; }
        public bool IsValid { get; set; }
        public int ReceptionId { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
