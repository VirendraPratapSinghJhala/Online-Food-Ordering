using FoodOrdering.Web.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrdering.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        public bool AddEmployee()
        {
            using (Online_Food_Ordering_SystemEntities db = new Online_Food_Ordering_SystemEntities())
            { 

            }
        }

        public bool DeleteEmployee(int empId)
        {

        }
    }
}