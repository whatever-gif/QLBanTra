//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLBanTra.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_details
    {
        public int order_detail_id { get; set; }
        public Nullable<int> order_id { get; set; }
        public Nullable<int> product_id { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}
