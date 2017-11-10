using System;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Assassin
    {
        private const string DEFAULT_NAME = "Frank";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 10;
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor;
        private Sword weapon;

        public int AbilityPoints
        {   get => abilityPoints;
            private set
            {
                if (value < 6)
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
                else
                {
                    this.abilityPoints = value;
                }
            }
        }

        public string Faction
        {
            get => faction;
            private set
            {
                if (value == "Melee")
                {
                    this.faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Wrong faction for this class!");
                }
            }
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

        public int Level
        {
            get => level;
            private set => level = value;
        }

        public string Name
        {
            get { return name; } 
            private set { this.name = value; }
        }

        public Sword BloodDrinker
        {
            get { return weapon; }
            private set { weapon = value;}
        }

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            private set { bodyArmor = value; }
        }

        public int Raze()
        {
            var damage = 10;
            return damage;
        }

        public int BleedToDeath()
        {
            var damage = 15;
            return damage;
        }

        public int Survival()
        {
            var healthBoost = 20;
            return healthBoost;
        }

        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Assassin(string name, int level, int health = DEFAULT_HEALTHPOINTS)
        {
            Name = name;
            Level = level;
            HealthPoints = health;
            Faction = "Melee";
            AbilityPoints = 6;
            BodyArmor = new LightLeatherVest();
            BloodDrinker  = new Sword();
        }
    }
}