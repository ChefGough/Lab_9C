﻿using System.Web.Mvc;
using System.Linq;
using Essential_Tools.Models;
using Ninject;


namespace Essential_Tools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products =
         {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "LifeJacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer Ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner Flag", Category = "Soccer", Price = 34.95M},
        };
        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }
        public ActionResult Index()
        {
           
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();
            return View(totalValue);
        }
    }
}