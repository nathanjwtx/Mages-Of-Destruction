using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Knight
    {
        private const string DEFAULT_NAME = "Bob";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 10;
        private int abilityPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
        private Sword sword;
        private Chainlink bodyArmor;

        public Sword DeathBringer
        {
            get => sword;
            private set { this.sword = value; }
        }

        public Chainlink BodyArmor
        {
            get => this.bodyArmor;
            private set { this.bodyArmor = value; }
        }

        public int AbilityPoints
        {   get => abilityPoints;
            set
            {
                if (value > 4)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
            }
        }
        
        public Faction Faction
        {
            get => faction;
            set => faction = value;
        }
        
        public int HealthPoints
        {
            get => healthPoints;
            set
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

        public int Level { get; set; }
        
        public string Name
        {
            get => name;
            set => name = value;
        }

        public int HolyBlow()
        {
            var damage = 15;
            return damage;
        }

        public int PurifySoul()
        {
            var healthBoost = 10;
            return healthBoost;
        }

        public int RighteousWings()
        {
            var damage = 13;
            return damage;
        }

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Knight(string name, int level, int health = DEFAULT_HEALTHPOINTS, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            HealthPoints = health;
            AbilityPoints = ability;
            Faction = Faction.Melee;
            DeathBringer = new Sword();
            BodyArmor = new Chainlink();
        }

    }
}