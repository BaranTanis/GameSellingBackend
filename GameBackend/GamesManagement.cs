using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GamesManagement
    {
        public void AddGame(Games game)
        {
            Console.WriteLine("Game Added");
        }

        public void DeleteGame(Games game)
        {
            Console.WriteLine("GameDeleted");
        }

        public void SellGame(List<Games> games, List<Gamers> gamers, List<Campaigns> campaigns)
        {
            foreach (var gamer in gamers)
            {

                foreach (var game in games)
                {

                    foreach (var campaign in campaigns)
                    {

                        Console.WriteLine(gamer.GamersId + "Id, " + gamer.GamersName + " Named, " + game.GameName + " GameName, " + game.GamePrice * campaign.PriceCut + " Bought...");
                    }
                }


            }
            Console.WriteLine(" Game SOLD");
        }
    }
}
