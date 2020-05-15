using FoodOrdering.Web.Models;
using FoodOrdering.Web.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodOrdering.Web.Services
{

    public class CustomerService : ICustomerService
    {
        public List<Customers> GetAllCustomers()
        {
            using (Online_Food_Ordering_SystemEntities db = new Online_Food_Ordering_SystemEntities())
            {
                List<Customers> customersList = db.Customers.ToList();

                db.Configuration.LazyLoadingEnabled = false;

                return customersList;

            }

        }
    }
}