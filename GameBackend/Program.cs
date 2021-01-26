using System;
using System.Collections.Generic;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaigns pricecut = new Campaigns() { };
            GamersManagement gamersManager = new GamersManagement() { };
            GamesManagement gamesManager = new GamesManagement() { };
            Games game = new Games() { };
            Gamers gamer = new Gamers() { };
            gamer.GamersId = "1234567890";
            gamer.GamersName = "Person";
            gamer.GamersEmail = "test@test.com";
            game.GameName = "Game";


            gamesManager.AddGame(game);
            gamersManager.TcKontrol(gamer);
            List<Games> games = new List<Games>() { game };
            List<Gamers> gamers = new List<Gamers>() { gamer };
            List<Campaigns> campains = new List<Campaigns>() { pricecut };

            gamesManager.SellGame(games, gamers, campains);
            gamesManager.
        }
    }
 }

