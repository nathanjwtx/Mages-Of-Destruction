﻿using System;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Characters.Spellcasters;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny
{
    class Program
    {
        static void Main(string[] args)
        {
            var nathan = new Warrior();
            Console.WriteLine(nathan.ThorsHammer.Attack);
        }
    }
}