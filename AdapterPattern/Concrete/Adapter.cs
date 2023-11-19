﻿using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class Adapter : Uyarlayıcı, ITarget
    {
        public string Request(int i)
        {
            return $"Tahmini sonuc: {Math.Round(SpecialRequest(i, 3))}";
        }
    }
}
