using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodOrdering.Web.Models
{

    public interface IFood_Items
    {
        
         int Food_Item_Id { get; set; }

        [Required(ErrorMessage ="Food Name Can not be left blank")]
        [StringLength(255)]
        [DisplayName("Food Name")]
        string Food_Name { get; set; }

        [Required(ErrorMessage = "Food Type Can not be left blank")]
        [StringLength(255)]
        [DisplayName("Food Type")]
        string Food_Type { get; set; }

        [Required(ErrorMessage = "Price Can not be left blank")]
        decimal Price { get; set; }
        
        bool IsActive { get; set; }
       
        System.DateTime Creation_Date { get; set; }
    }

    [MetadataType(typeof(IFood_Items))]
    public partial class Food_Items
    {

       

    }
}