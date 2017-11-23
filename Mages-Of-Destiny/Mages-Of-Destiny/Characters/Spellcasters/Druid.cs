using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Druid : Brains
    {
        private const string DEFAULT_NAME = "Adam";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private int _healthPoints;
        private int _mana;
        private Staff staff;
        private LightLeatherVest vest;

        public Staff RodOfLife
        {
            get => staff;
            private set => staff = value;
        }

        public LightLeatherVest BarkSkinLeatherVest
        {
            get => vest;
            private set => vest = value;
        }
        
        public override int HealthPoints
        {
            get => _healthPoints;
            set
            {
                if (value > 100)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Health too low");
                }
            }
        }

        public int Moonfire()
        {
            var damage = 13;
            return damage;
        }

        public int Starburst()
        {
            var damage = 15;
            return damage;
        }

        public int OneWithNature()
        {
            var healthBoost = 10;
            return healthBoost;
        }

        public Druid(int mana)
            : base(mana)
        {}
        
        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS)
        {}
        
        public Druid(string name, int level, int health = DEFAULT_HEALTHPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            Faction = Faction.Mage;
            RodOfLife = new Staff();
            BarkSkinLeatherVest = new LightLeatherVest();
        }
    }
}