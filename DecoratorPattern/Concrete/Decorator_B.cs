using DecoratorPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Concrete
{
    public class Decorator_B : IBilesen
    {
        private IBilesen _bilesen;

        public Decorator_B(IBilesen bilesen)
        {
            _bilesen = bilesen;
        }
        public string Operation() => _bilesen.Operation() + "RPA projeleri geliştiriyorum.";

        public string EkDavranis() => "Yüksek lisans yapıyorum!";
    }
}
