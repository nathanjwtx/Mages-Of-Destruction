using System;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Warrior
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Hammer hammer = new Hammer();
        private Chainlink chainlink = new Chainlink();

        public string Faction
        {
            get => faction;
            set
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
            set
            {
                if (value < 10)
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points set too low");
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }
        
        public int AbilityPoints
        {   get => abilityPoints;
            set
            {
                if (value < 5)
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
                else
                {
                    this.abilityPoints = value;
                }
            }
        }

        public Hammer ThorsHammer
        {
            get { return hammer; }
        }

        public Chainlink MythrilChain
        {
            get { return chainlink; }
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

        public Warrior(string faction, int ability, int health)
        {
            this.AbilityPoints = ability;
            this.HealthPoints = health;
            this.Faction = faction;
        }
    }
}