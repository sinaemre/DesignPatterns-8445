using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Concrete
{
    public class Uyarlayıcı
    {
        public double SpecialRequest(double a, double b) => a / b;
    }
}
