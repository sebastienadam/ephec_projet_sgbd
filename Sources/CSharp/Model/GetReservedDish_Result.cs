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
    
    public partial class GetReservedDish_Result
    {
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string DishType { get; set; }
        public string DishName { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> DishId { get; set; }
        public Nullable<int> DishTypeId { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
