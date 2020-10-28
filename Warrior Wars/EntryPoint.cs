using System;
using System.Threading;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();
        static void Main()
        {
            Warrior goodGuy = new Warrior("Dhriti", Enum.Faction.GoodGuy);
            Warrior badGuy = new Warrior("Riya", Enum.Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0, 10) < 5)
                {
                    goodGuy.Attack(badGuy);

                }
                else
                {
                    badGuy.Attack(goodGuy);
                    
                }
                Thread.Sleep(100);
            }




           
        }
    }
}
