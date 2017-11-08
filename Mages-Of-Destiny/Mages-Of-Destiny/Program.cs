using System;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny
{
    class Program
    {
        static void Main(string[] args)
        {
            var nathan = new Assassin();
            nathan.Name = "Nathan";
            Console.WriteLine(nathan.BloodDrinker.Damage);

            var sword = new Sword();
            Console.WriteLine(sword.Bloodthirst);
        }
    }
}