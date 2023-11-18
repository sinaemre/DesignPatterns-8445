﻿using FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Concrete
{
    public class Product_B : IProduct
    {
        public string ShipFrom() => "from Colombia!";
    }
}
