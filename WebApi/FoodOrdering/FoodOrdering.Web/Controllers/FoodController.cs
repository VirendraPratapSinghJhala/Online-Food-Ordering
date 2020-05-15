using FoodOrdering.Web.ExceptionLayer;
using FoodOrdering.Web.Models;
using FoodOrdering.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace FoodOrdering.Web.Controllers
{
    public class FoodController : ApiController
    {

        public List<Food_Item> GetAllFoodItems()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //instantiate FoodService class
                    FoodService fs = new FoodService();

                    //Call GetAllFoodItems() to fetch all Food Items 
                    List<Food_Item> foodItemsList = fs.GetAllFoodItems();

                    //return the response
                    return foodItemsList;
                }
                catch (FoodOrderException)
                {
                    throw ;
                } 
            }
            
            else
            {
                //throw user defined exception object 
                throw new FoodOrderException("The entered details to fetch the Food Items are not valid");
            }
        }


        public Food_Item GetFoodItemById(int Food_Item_Id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //instantiate FoodService class
                    FoodService fs = new FoodService();

                    //Call GetAllFoodItems() to fetch all Food Items 
                    Food_Item foodItem = fs.GetFoodItemById(Food_Item_Id);

                    //return the response
                    return foodItem;
                }
                catch (FoodOrderException)
                {
                    throw;
                }
            }

            else
            {
                //throw user defined exception object 
                throw new FoodOrderException("The entered details to fetch the Food Items are not valid");
            }
        }


        public List<Food_Item> GetAllFoodItems()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //instantiate FoodService class
                    FoodService fs = new FoodService();

                    //Call GetAllFoodItems() to fetch all Food Items 
                    List<Food_Item> foodItemsList = fs.GetAllFoodItems();

                    //return the response
                    return foodItemsList;
                }
                catch (FoodOrderException)
                {
                    throw;
                }
            }

            else
            {
                //throw user defined exception object 
                throw new FoodOrderException("The entered details to fetch the Food Items are not valid");
            }
        }

        public List<Food_Item> GetAllFoodItems()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //instantiate FoodService class
                    FoodService fs = new FoodService();

                    //Call GetAllFoodItems() to fetch all Food Items 
                    List<Food_Item> foodItemsList = fs.GetAllFoodItems();

                    //return the response
                    return foodItemsList;
                }
                catch (FoodOrderException)
                {
                    throw;
                }
            }

            else
            {
                //throw user defined exception object 
                throw new FoodOrderException("The entered details to fetch the Food Items are not valid");
            }
        }

    }
}
