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
    using System.Collections.Generic;
    
    public partial class DishWish
    {
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public string Feeling { get; set; }
        public string DishType { get; set; }
        public string DishName { get; set; }
        public int ClientId { get; set; }
        public int DishId { get; set; }
        public int DishTypeId { get; set; }
        public int FeelingTypeId { get; set; }
        public Nullable<System.DateTime> ModifiedAt { get; set; }
        public string ModifiedBy { get; set; }
    }
}
