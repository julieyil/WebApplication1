using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
    }

    private IEnumerable<Customer> GetCustomers()
    {
        return new List<Customer>
            {
                new Customer {Id=1, Name="Julie Y."},
                new Customer{Id=2, Name="Antoine J."}
            };
    }
}
}