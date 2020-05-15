using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodOrdering.Web.Models
{

    public interface IFood_Items
    {
        [Required]
         int Food_Item_Id { get; set; }

        [Required]
        string Food_Name { get; set; }

        [Required]
        string Food_Type { get; set; }

        [Required]
        decimal Price { get; set; }

        [Required]
        bool IsActive { get; set; }

        [Required]
        System.DateTime Creation_Date { get; set; }
    }

    [MetadataType(typeof(IFood_Items))]
    public partial class Food_Items
    {

       

    }
}