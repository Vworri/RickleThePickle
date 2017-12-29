using RickleThePickle.PlayerStuctures;
using System;


namespace RickleThePickle.PlayerStuctures
{
    public static class Player
    {
       
        public struct PlayerAtrributes
        {
            public string name;
            public int age;
            public Roles role;
            
        }
        public static PlayerAtrributes CreatePlayer(int i, bool infinateloophell = true)
        {
            Console.WriteLine("What is Player{0}'s name?", i);
            string name;
            name = Console.ReadLine();
            Console.WriteLine("What is {0}'s  age?", name);
            string AgeText;
            AgeText = Console.ReadLine();
            int age = -1;
            while (infinateloophell)
            {
                try
                {
                    age = Int32.Parse(AgeText);
                    infinateloophell = false;
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Please Put in an integer :{");
                    AgeText = Console.ReadLine();
                }
            }

            Console.WriteLine("What is {0}'s role?", name);
            string role = Console.ReadLine();
            
            PlayerAtrributes player = new  PlayerAtrributes();
            player.age = age;
            player.role = new Roles(role);
            player.name = name;
            return player;
        }

    }


}