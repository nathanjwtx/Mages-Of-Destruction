using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Warrior: Brawn
    {
        private const string DEFAULT_NAME = "Will";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 100;
        private const int DEFAULT_ABILITYPOINTS = 7;
        private int _abilityPoints;
        private int _healthPoints;
        private Hammer hammer;
        private Chainlink chainlink;

        public override int HealthPoints
        {
            get => _healthPoints;
            set
            {
                if (value > 50)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points set too low");
                }
            }
        }
        
        public override int AbilityPoints
        {   get => _abilityPoints;
            set
            {
                if (value > 5)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
            }
        }

        public Hammer ThorsHammer
        {
            get => hammer;
            private set => hammer = value;
        }

        public Chainlink MythrilChain
        {
            get => chainlink;
            private set => chainlink = value;
        }

        public int Strike()
        {
            var damage = 13;
            return damage;
        }

        public int Execute()
        {
            var damage = 16;
            return damage;
        }
        public int SkinHarden()
        {
            var healthBoost = 20;
            return healthBoost;
        }

        public Warrior(int ability)
            : base(ability)
        {}
        
        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Warrior(string name, int level)
            : this(name, level, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Warrior(string name, int level, int health, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            Faction = Faction.Melee;
            _abilityPoints = ability;
            ThorsHammer = new Hammer();
            MythrilChain = new Chainlink();
        }
    }
}