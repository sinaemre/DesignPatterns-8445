using DecoratorPattern.Clients;
using DecoratorPattern.Concrete;
using DecoratorPattern.Interface;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBilesen bilesen = new Bilesen();

            Client.Display("1. Ham Hali => ", bilesen);
            Client.Display("2. Hali Dekorator_A ile modifiye edilmiş => ", new Decorator_A(bilesen));
            Client.Display("3. Hali Dekorator_B ile modifiye edilmiş => ", new Decorator_B(bilesen));
            Client.Display("4. Hali önce Dekorator_B ile sonra Dekorator_A ile modifiye edilmiş => ", new Decorator_A(new Decorator_B(bilesen)));

            //Ek davranış kullanımı
            Client.Display(new Decorator_B(bilesen).EkDavranis(), new Decorator_B(bilesen));
        }
    }
}