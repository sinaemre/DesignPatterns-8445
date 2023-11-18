using FactoryPattern.Creator;
using FactoryPattern.Interface;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCreator productCreator = new ProductCreator();
            IProduct product;
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            for (int i = 1; i <= 12; i++)
            {
                product = productCreator.FactoryMethod(i);
                Console.WriteLine(months[i - 1] + " - Coffee Beans => " + product.ShipFrom());
            }
        }
    }
}