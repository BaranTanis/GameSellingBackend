using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    interface IGameBuyers
    {
        void AddGame(Games game);
        void DeleteGame(Games game);
        void SellingGame(List<Games> games, List<Gamers> gamers, List<Campaigns> campaigns);
    }
}
