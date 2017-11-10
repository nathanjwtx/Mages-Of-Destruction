using System;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Druid
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Staff staff = new Staff();
        private LightLeatherVest vest = new LightLeatherVest();

        public Staff RodOfLife => staff;
        public LightLeatherVest BarkSkin => vest;
        
        public string Faction
        {
            get => faction;
            set
            {
                if (value == "Mage")
                {
                    this.faction = value;   
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Wrong faction for this class");
                }
            }
        }

        public int HealthPoints
        {
            get => healthPoints;
            set
            {
                if (value > 4)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Health too low");
                }
            }
        }

        public int AbilityPoints
        {
            get => abilityPoints;
            set
            {
                if (value > 5)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Ability too low");
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

        public Druid(string faction, int ability, int health)
        {
            this.AbilityPoints = ability;
            this.HealthPoints = health;
            this.Faction = faction;
        }
    }
}