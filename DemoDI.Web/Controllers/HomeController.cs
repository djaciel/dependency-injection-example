using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoDI.Web.Models;
using DemoDI.Services;

namespace DemoDI.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerService customerService;

        public HomeController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }
        public IActionResult Index()
        {
            return View(customerService.GetCustomers());
        }
    }
}
