using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class Bilesen : IBilesen
    {
        public string Operation() => "Çalıştığım firma için ";
    }
}
