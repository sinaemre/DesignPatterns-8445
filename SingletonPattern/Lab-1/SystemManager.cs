using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab_1
{
    public class SystemManager
    {
        private static SystemManager _systemManager;

        //Burada amaç bu sınıfın dışarıdan erişilerek örneklemini alınmasını engellemektir. 
        private SystemManager() { }

        //Sınıfın örneklemini dışarıda alamayacağız çünkü constructor'ı private yaptık. Bunun yerine nesneyi sınıfın kendi içerisinde kontrollü bir şekilde custom bir method ya da property üzerinden nesnenin üretilmesini kontrol altına alarak üretilmesini temin ettik.
        public static SystemManager CreateSingletonObject()
        {
            //Uygulamanın herhangi bir yerinde "SystemManager." diyerek CreateSingletonObject() methodunu çağırabiliri bu methodta bana SystemMAnager.cs sınıfnın örneklemini bir şart doğrultusunda yaratır ya da var olanı teslim eder.
            if (_systemManager == null) //eğer _systemMAnager field'e içerisi boşsa şart tutar
            {
                _systemManager = new SystemManager(); //nesne üretilir
            }
            //_systemManager nesnesi zaten dolu ise direk bize onu teslim eder.
            return _systemManager; //nesne dönülür.
        }

        public void CreateLog() => Console.WriteLine("A log was created!");
    }
}
