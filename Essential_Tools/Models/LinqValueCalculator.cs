﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Essential_Tools.Models
{
    public class LinqValueCalculator : IValueCalculator
    {
        private IDiscountHelper discounter;
        private static int counter = 0;
        
        public LinqValueCalculator(IDiscountHelper discountParam)
        {
            discounter = discountParam;
            System.Diagnostics.Debug.WriteLine(string.Format("Intance {0} created", ++counter));
        }
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return discounter.ApplyDiscount (products.Sum(p => p.Price));
        }
    }
}