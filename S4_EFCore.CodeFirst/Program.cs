using S4_EFCore.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S4_EFCore.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new MundialDBContext();

            //var player1 = new Player();
            //player1.FullName = "Cristiano Ronaldo";
            //player1.Dorsal = 7;

            //context.Player.Add(player1);
            //context.SaveChanges();

            //var player2 = new Player();
            //player2.FullName = "Lionel Messi";
            //player2.Dorsal = 10;

            //var player3 = new Player();
            //player3.FullName = "Paolo Guerrero";
            //player3.Dorsal = 9;

            //var player4 = new Player();
            //player4.FullName = "Gianluca Lapadula";
            //player4.Dorsal = 21;

            //var players = new List<Player>();
            //players.Add(player2);
            //players.Add(player3);
            //players.Add(player4);

            //context.Player.AddRange(players);
            //context.SaveChanges();

            //LINQ Expressions

            //var searchPlayer = (from p in context.Player
            //                    where p.Dorsal == 9
            //                    select p).FirstOrDefault();

            //Console.WriteLine("Jugador Encontrado: "
            //                    + searchPlayer.FullName
            //                    + " Dorsal: " + searchPlayer.Dorsal);

            //context.Player.Remove(searchPlayer);
            //context.SaveChanges();
            //Console.WriteLine("Jugador eliminado");

            //var searchPlayer = (from p in context.Player
            //                    where p.Dorsal == 10
            //                    select p).FirstOrDefault();

            //searchPlayer.FullName = "Jefferson Farfan";
            //context.SaveChanges();

            var searchListPlayer = (from p in context.Player
                                where p.Dorsal == 7
                                select p).ToList();

            foreach (var item in searchListPlayer)
            {
                Console.WriteLine("Jugador Encontrado: "
                                    + item.FullName
                                    + " Dorsal: " + item.Dorsal);
            }

            //Query Lambda Expressions

            var searchListPlayerLambda = context.Player.Where(x => x.Dorsal == 7).ToList();


            Console.WriteLine("Hello World!");
        }
    }
}
