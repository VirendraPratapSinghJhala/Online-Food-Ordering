using FoodOrdering.Web.Models;
using FoodOrdering.Web.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrdering.Web.Services
{

    public class FoodsService:IFoodsService
    {
        public List<Food_Items> GetAllFoodItems()
        {
            using (Online_Food_Ordering_SystemEntities db=new Online_Food_Ordering_SystemEntities())
            {
                List<Food_Items> foodItemsList= db.Food_Items.ToList();

                db.Configuration.LazyLoadingEnabled = false;

                return foodItemsList;

            }
                
        }
    }
}