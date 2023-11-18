using SingletonPattern.Lab_1;
using SingletonPattern.Lab_2;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lab-1
            //Aşağıdaki kodu aktifleştirdiğimde Constructor bize kızdı, çünkü erişilebilir durumda değil. Teorik olarakta söylediğimiz gibi singleton ile üretilen nesneleri uygulamanın herhangi bir yerinde çağırabiliriz. Ama yeniden üretemeyiz.
            //SystemManager systemManager = new SystemManager();

            SystemManager systemManager = SystemManager.CreateSingletonObject(); //Bu custom method vasıtasıyla SystemManager.cs sınıfndan bir nesne sınıfın içerisinde kontrollü bir şekilde üretilecek ve bize burada geri döndürülecek.

            systemManager.CreateLog(); //sytemManager değişkeni üzerinden SystemMAnager.cs sınıfın içerisinde olan CreateLog() methoduna eriştim. Normalde bu method instance method olduğundan ona sadece örneklem üzerinden erişebilirim.
            #endregion

            #region Lab - 2
            Console.WriteLine($"Sonuç => {SingletonClass.SingletonObject.Toplam(3,2)}");
            #endregion

        }
    }
}