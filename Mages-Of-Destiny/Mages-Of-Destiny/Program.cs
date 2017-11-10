using System;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Characters.Spellcasters;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = 40;
            var nathan = new Assassin("Nathan", 1);
            Console.WriteLine(nathan.Name);
            Console.WriteLine(nathan.HealthPoints);

        }
    }
}