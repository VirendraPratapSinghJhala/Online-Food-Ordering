//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoodOrdering.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food_Items
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food_Items()
        {
            this.Order_Items = new HashSet<Order_Items>();
        }
    
        public int Food_Item_Id { get; set; }
        public string Food_Name { get; set; }
        public string Food_Type { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime Creation_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Items> Order_Items { get; set; }
    }
}
