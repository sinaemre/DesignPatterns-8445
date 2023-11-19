using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheChainOfResponsibility.Abstract;

namespace TheChainOfResponsibility.Concrete
{
    public class HandlerAVI : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".avi"))
            {
                Console.WriteLine($"{fileType} tipinde medya oynatılıyor!");
            }
            else
            {
                Console.WriteLine("Geçersiz medya tipi!!");
            }
        }
    }
}
