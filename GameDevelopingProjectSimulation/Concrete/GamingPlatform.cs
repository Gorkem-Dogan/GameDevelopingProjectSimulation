using GameDevelopingProjectSimulation.Abstract;
using GameDevelopingProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDevelopingProjectSimulation.Concrete
{
    public class GamingPlatform : IGamingPlatformManager, IGameOfferManager, IPlayerInformationManager
    {
        public void SalesProcess(Player player, GamesList game)
        {

            Console.WriteLine("Satın alımın için teşekkür ederiz " + player.NickName + " " + game.GameName + " Hesabına eklenmiştir");
            Console.WriteLine( (game.GamePrice - game.GamePrice/4) +" Liralık %25 indirimli alışverişinin Faturası email adresine gönderilecektir");
        }
        public void Register(Player player)
        {
            Console.WriteLine("Kayıt olduğun için teşekkürler " + player.FirstName + " " + player.lastName);
        }
        public void Unregister()
        {

        }
        public void Update() 
        {

        }
        public void Discount() 
        {
                
        }
    }
}
