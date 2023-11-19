using MediatorPattern.Interface;
using MediatorPattern.Mediator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Concrete
{
    public class BasicUser : IUser
    {
        private readonly string _userName;
        private readonly IChatMediator _chatMediator;

        public BasicUser(string userName, IChatMediator chatMediator)
        {
            _userName = userName;
            _chatMediator = chatMediator;
        }

        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Kullanıcı Tipi: Basic\nKullanıcı Adı: {_userName}\nAlınan Mesaj: {message}");
        }

        public void SendMessage(string message)
        {
            _chatMediator.SendMessage(message, this);
        }
    }
}
