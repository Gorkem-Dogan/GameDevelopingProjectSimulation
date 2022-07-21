using GameDevelopingProjectSimulation.Abstract;
using GameDevelopingProjectSimulation.Concrete;
using GameDevelopingProjectSimulation.Entities;
using System.Collections.Generic;

Player player1 = new Player 
{FirstName="Görkem", lastName="Doğan", NationalityId="1235326736", NickName="Tintalle"
};
GamesList games1 = new GamesList
{
    GameName = "Call of duty",
    GamePrice = 600
};
GamesList games2 = new GamesList
{
    GameName = "Mount and Blade 2 Bannerlord",
    GamePrice = 250
};
IGamingPlatformManager gamingPlatform = new GamingPlatform();


gamingPlatform.Register(player1);
gamingPlatform.SalesProcess(player1, games1);