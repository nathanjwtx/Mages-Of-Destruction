using System;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Characters.Spellcasters;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny
{
    class Program
    {
        static void Main(string[] args)
        {
            var health = 160;
            var nathan = new Mage(100);
            var bob = new Warrior();
            nathan.Mana = 100;
            Console.WriteLine(nathan.Mana);
            nathan.CastSpell(bob, nathan);
            Console.WriteLine(bob.Name);
        }
    }
}