using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FoodOrdering.Web.Controllers
{
    public class EmployeeController : ApiController
    {
        public IHttpActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeService fs = new EmployeeService();
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
