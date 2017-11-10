using System;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Assassin
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private LightLeatherVest bodyArmor = new LightLeatherVest();
        private Sword weapon = new Sword();

        public int AbilityPoints
        {   get => abilityPoints;
            set
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

        public int Level { get; set; }
        public string Name { get; set; }

        public Sword BloodDrinker
        {
            get { return weapon; }
            set { weapon = value;}
        }

        public LightLeatherVest BodyArmor
        {
            get { return bodyArmor; }
            set { bodyArmor = value; }
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

        public Assassin(string faction, int ability, int health)
        {
            this.HealthPoints = health;
            this.AbilityPoints = ability;
            this.Faction = faction;
        }
    }
}