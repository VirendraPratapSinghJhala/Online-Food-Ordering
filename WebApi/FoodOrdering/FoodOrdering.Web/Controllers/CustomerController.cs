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
    public class CustomerController : ApiController
    {

        public IHttpActionResult GetAllCustomers()
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CustomerService cs = new CustomerService();
                    List<Customers> customersList = cs.GetAllCustomers();
                    return Ok(customersList);
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
