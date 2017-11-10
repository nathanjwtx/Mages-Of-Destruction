using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Warrior
    {
        private const string DEFAULT_NAME = "Will";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 7;
        private int abilityPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Hammer hammer;
        private Chainlink chainlink;

        public Faction Faction
        {
            get => faction;
            private set => faction = value;
        }
        
        public int HealthPoints
        {
            get => healthPoints;
            private set
            {
                if (value > 10)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points set too low");
                }
            }
        }
        
        public int AbilityPoints
        {   get => abilityPoints;
            private set
            {
                if (value > 5)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
            }
        }

        public string Name
        {
            get => name;
            private set => name = value;
        }

        public int Level
        {
            get => level;
            private set => level = value;
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
            HealthPoints = health;
            Faction = Faction.Melee;
            AbilityPoints = ability;
            ThorsHammer = new Hammer();
            MythrilChain = new Chainlink();
        }
    }
}