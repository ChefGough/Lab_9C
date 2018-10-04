using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Essential_Tools.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }
}