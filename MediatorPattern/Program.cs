using MediatorPattern.Concrete;
using MediatorPattern.Interface;
using MediatorPattern.Mediator.Concrete;
using MediatorPattern.Mediator.Interface;

namespace MediatorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser arda = new BasicUser("jazox", chatMediator);
            IUser hazar = new GoldUser("catch-up", chatMediator);
            IUser idil = new GoldUser("Idile", chatMediator);

            chatMediator.AddUser(arda);
            chatMediator.AddUser(hazar);
            chatMediator.AddUser(idil);

            Console.WriteLine("Hazarın mesaji: ");
            hazar.SendMessage("Tavuk - Pilav ketçapsız yenmez! Ketçapsız yiyen ağzının tadını bilmiyordur!");

            Console.WriteLine("\nArdanın mesajı: ");
            arda.SendMessage("Sen aklına koyduğun herşeyi başarırsın!");
        }
    }
}