using System;
using System.Collections.ObjectModel;
using Interfaces;
using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public class Brains : Character, ISpellCaster
    {
        private int _abilityPoints;

        public virtual int AbilityPoints
        {
            get => _abilityPoints; 
            set => _abilityPoints = value;
        }

        public Brains()
        {}

        public Brains(int ability)
        {
            _abilityPoints = ability;
        }

        public Brains(int health, int level, string name, Faction faction)
            : base(health, level, name, faction)
        {}

        public int Mana { get; set; }
        public void CastSpell(Character mage, int spellDamage)
        {
            var msg = string.Format("{0} casts a spell with {1} damage", mage.Name, spellDamage);
            Console.WriteLine(msg);
        }
    }
}