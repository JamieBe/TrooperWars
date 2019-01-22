using System;
using System.Threading;
using TrooperWars.Enum;

namespace TrooperWars
{
    class EntryPoint
    {
        static Random rng = new Random();
        static void Main()
        {
            Trooper goodGuy = new Trooper("Bob", Faction.GoodGuy);
            Trooper badGuy = new Trooper("Bill", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive) 
            {
                if (rng.Next(0,10) < 5)
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
