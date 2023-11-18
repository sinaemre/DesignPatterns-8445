using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Concrete
{
    public class DefaultProduct : IProduct
    {
        public string ShipFrom() => "Shipping isn't available...";
    }
}
