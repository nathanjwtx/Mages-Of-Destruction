using System;
using System.Dynamic;
using System.Security.Cryptography;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Mage : Brains
    {
        private const string DEFAULT_NAME = "Tim";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 9;
        private int _abilityPoints;
        private int _healthPoints;
        private Staff staff;
        private ClothRobe robe;

        public Staff RodOfElectricity
        {
            get => staff;
            private set => staff = value;
        }

        public ClothRobe RobeOfIllumination
        {
            get => robe;
            private set => robe = value;
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

        public override int AbilityPoints
        {
            get => _abilityPoints;
            set
            {
                if (value > 5)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Ability too low");
                }
            }
        }

        public int ArcaneWrath()
        {
            var damage = 13;
            return damage;
        }

        public int Firewall()
        {
            var damage = 15;
            return damage;
        }

        public int Meditation()
        {
            var healthBoost = 10;
            return healthBoost;
        }

        public Mage(int ability)
            : base(ability)
        {}
        
        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Mage(string name, int level, int health = DEFAULT_HEALTHPOINTS, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            _abilityPoints = ability;
            Faction = Faction.Mage;
            RodOfElectricity = new Staff();
            RobeOfIllumination = new ClothRobe();
        }
    }
}