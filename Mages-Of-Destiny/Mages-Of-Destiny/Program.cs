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
            var Bob = new Assassin("Bob", 2, 120, 70);

            chars.Add(Max);
            chars.Add(Bob);
            Fight(chars);
            
        }

        static void Fight(List<Character> characters)
        {
            Random rnd1 = new Random();
            var charTurn = rnd1.Next(0, 6);
            
            foreach (Character c in characters)
            {
                c.Attack();
//                if (c is Mage)
//                {
//                    var tempMage = new Mage();
//                    tempMage.CastSpell(c, tempMage.ArcaneWrath());
//                }
//                else if (c is Druid)
//                {
//                    var tempDruid = new Druid();
//                    tempDruid.CastSpell(c, tempDruid.Moonfire());
//                }
            }
        }
    }
}