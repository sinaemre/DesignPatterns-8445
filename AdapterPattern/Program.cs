using AdapterPattern.Concrete;
using AdapterPattern.Interface;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();

            Console.WriteLine(target.Request(5));

        }
    }
}