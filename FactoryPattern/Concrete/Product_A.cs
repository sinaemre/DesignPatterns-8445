using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Concrete
{
    public class Product_A : IProduct
    {
        public string ShipFrom() => "from South Africa";
    }
}
