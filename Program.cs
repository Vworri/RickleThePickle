using System;
using System.Collections.Generic;
using RickleThePickle.PlayerStuctures;

namespace RickleThePickle
{



    internal class Program
    {
        public static void Main(string[] args)
        {
            int? num = null;
            bool infinateloophell = true;
            Console.WriteLine("What is the name of the game?");
            string GameName = Console.ReadLine();
            Console.WriteLine("How many Players?");
            List<Player.PlayerAtrributes> production_cast = new List<Player.PlayerAtrributes>();

            while (infinateloophell)
            {
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                    infinateloophell = false;
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please Put in an integer(1,2,3...) :");
                }
            }

            for (int i = 1; i <= num; i++)
            {
                Player.PlayerAtrributes cast_member = Player.CreatePlayer(i, true);
                production_cast.Add(cast_member);
            }
            Console.WriteLine(production_cast[0].role.GetType().GetField("Am").GetValue());
        }

       
    }
}