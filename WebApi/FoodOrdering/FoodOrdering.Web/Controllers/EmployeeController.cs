using FoodOrdering.Web.Models;
using FoodOrdering.Web.Services;
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
                    bool addStatus = fs.AddEmployee();
                    return Ok(addStatus);
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

        public IHttpActionResult DeleteEmployee(int empId)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeService fs = new EmployeeService();
                    bool deleteStatus = fs.DeleteEmployee(empId);
                    return Ok(deleteStatus);
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

        public IHttpActionResult UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    EmployeeService fs = new EmployeeService();
                    bool addStatus = fs.AddEmployee();
                    return Ok(addStatus);
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
