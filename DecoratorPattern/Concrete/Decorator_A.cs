using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class Decorator_A : IBilesen
    {
        private IBilesen _bilesen;

        public Decorator_A(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }

        public string Operation() => _bilesen.Operation() + "yazılım tanımlı ağlar projesi geliştiriyorum!";
    }
}
