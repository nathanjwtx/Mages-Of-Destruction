﻿using System.Collections.ObjectModel;
using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public class Brains : Characters
    {
        private int _mana;

        public virtual int Mana { get; set; }

        public Brains()
        {}

        public Brains(int mana)
        {
            _mana = mana;
        }

        public Brains(int health, int level, string name, Faction faction)
            : base(health, level, name, faction)
        {}
    }
}