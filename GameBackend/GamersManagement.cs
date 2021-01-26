using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    class GamersManagement
    {
        public void AddGamer(Gamers gamer)
        {
            Console.WriteLine(gamer.GamersName + " Record Created For Gamer...");
        }
        public void DeleteGamer(Gamers gamer)
        {

            Console.WriteLine(gamer.GamersId + " " + gamer.GamersName + " " + gamer.GamersEmail + " " + " Gamer Deleted.");
        }

        public void TcKontrol(Gamers gamer)
        {

            Console.WriteLine("Id control check");

        }
    }
}
