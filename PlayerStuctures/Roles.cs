using System;

namespace RickleThePickle.PlayerStuctures
{
    public class Roles
    
    {
        public struct PersonsActions
        {
            public int CanDance;
            public int CanEat;
            public int CanPoo;
            public int CanBS;
            public int CanRead;
            public int CanWrite;
            public int CanDrink;

        }

        public struct Personality
        {   public int Troll;
            public int Naive;
            public int Boring;
            public int Exciting;

        }
        public  struct GeneratedRole
        {
            public string title;
            public PersonsActions Do;
            public Personality Am;
            
        }
        
        public Roles(string Role)
        {
          GeneratedRole person = new GeneratedRole();
            person.title = Role;
            person.Do = generateActions();
            person.Am = generatePersonality();

        }
       

     

        public static PersonsActions generateActions()
        {
            PersonsActions personsActions = new PersonsActions();
            Random rnd = new Random();
            personsActions.CanDance = rnd.Next(1001);
            personsActions.CanEat  = rnd.Next(1001);
            personsActions.CanPoo  = rnd.Next(1001);
            personsActions.CanBS  = rnd.Next(1001);
            personsActions.CanRead  = rnd.Next(1001);
            personsActions.CanWrite  = rnd.Next(1001);
            personsActions.CanDrink  = rnd.Next(1001);

            return personsActions;
        }

        public Personality generatePersonality()
        {
            Personality person = new Personality();
            Random rnd = new Random();
            person.Troll= rnd.Next(1001);
            person.Naive = rnd.Next(1001);
            person.Boring = rnd.Next(1001);
            person.Exciting = rnd.Next(1001);
            return person;
        }
    }
}