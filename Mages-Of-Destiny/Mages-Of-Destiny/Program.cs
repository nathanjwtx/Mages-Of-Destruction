using System;
using System.Collections.Generic;
using Mages_Of_Destiny.Characters;
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
            var chars = new List<Character>();

            var Max = new Mage("Max", 2, 100, 50);
            var Bob = new Druid();

            chars.Add(Max);
            chars.Add(Bob);

            foreach (Character c in chars)
            {
                if (c is Mage)
                {
                    var tempMage = new Mage();
                    tempMage.CastSpell(tempMage, tempMage.ArcaneWrath());
                }
            }
            
        }
    }
}