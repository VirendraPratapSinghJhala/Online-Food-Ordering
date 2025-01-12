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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public int Age { get; set; }
        public Nullable<int> Store_Id { get; set; }
        public string Password { get; set; }
        public string Mobile_No { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime Creation_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        public virtual Food_Store Food_Stores { get; set; }
    }
}
