using TheChainOfResponsibility.Abstract;
using TheChainOfResponsibility.Concrete;

namespace TheChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zincirin halkalarını tanımladık
            PlayerHandler aviPlayer = new HandlerAVI();
            PlayerHandler mp3Player = new HandlerMP3();
            PlayerHandler mp4Player = new HandlerMP4();

            //Zinciri oluşturuyoruz
            mp3Player.NextHandler = mp4Player;
            mp4Player.NextHandler = aviPlayer;

            //Requestleri zincirin ilk halkasına gönderiyorsunuz.
            mp3Player.Player("video.mp4");
            mp3Player.Player("video.avi");
            mp3Player.Player("video.mp3");
            mp3Player.Player("video.mpg");


        }
    }
}