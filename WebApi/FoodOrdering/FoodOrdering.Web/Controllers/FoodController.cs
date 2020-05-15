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

        public IHttpActionResult GetAllFoodItems()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    FoodsService fs = new FoodsService();
                    List<Food_Items> foodItemsList = fs.GetAllFoodItems();
                    return Ok(foodItemsList);
                }
                catch (Exception ex)
                {

                    throw ex;
                } 
            }
            
            else
            {
                return BadRequest();
            }
        }
          

    }
}
