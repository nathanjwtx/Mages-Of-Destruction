using System;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Knight
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Sword sword = new Sword();
        private Chainlink bodyArmor = new Chainlink();

        public Sword DeathBringer => sword;

        public Chainlink BodyArmor { get => this.bodyArmor;}

        public int AbilityPoints
        {   get => abilityPoints;
            set
            {
                if (value < 4)
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

        public Knight(string faction, int ability, int health)
        {
            this.AbilityPoints = ability;
            this.HealthPoints = health;
            this.Faction = faction;
        }

    }
}