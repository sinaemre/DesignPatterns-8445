using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Lab_2
{
    public class SingletonClass
    {
        private static SingletonClass _singleObject;
        private SingletonClass()
        {
            
        }

        public static SingletonClass SingletonObject 
        {
            get 
            {
                if (_singleObject == null)
                {
                    _singleObject = new SingletonClass();
                }
                return _singleObject;
            }
        }

        public int Toplam(int s1, int s2) => s1 + s2;
    }
}
