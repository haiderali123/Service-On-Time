//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Community2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Availability_Slots
    {
        public int Id { get; set; }
        public Nullable<int> wid { get; set; }
        public string Availability_Slots1 { get; set; }
        public Nullable<int> IsAvailable { get; set; }
    
        public virtual worker_Portfolio worker_Portfolio { get; set; }
    }
}
