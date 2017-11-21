using System;
using System.Collections.Generic;
using System.Text;

namespace Weapons
{
    public class Spell
    {
        private int manaCost;
        private int damage;

        public int ManaCost
        {
            get => this.manaCost;
            set => this.manaCost = value;
        }

        public int Damage
        {
            get => this.damage;
            set => this.damage = value;
        }

        public Spell()
        {
            this.manaCost = 10;
            this.damage = 12;
        }

    }
}
