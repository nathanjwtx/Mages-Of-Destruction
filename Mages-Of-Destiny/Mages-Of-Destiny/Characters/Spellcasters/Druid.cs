using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Druid
    {
        private const string DEFAULT_NAME = "Adam";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 10;
        private int abilityPoints;
        private Faction faction;
        private int healthPoints;
        private int level;
        private string name;
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
            private set
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

        public int Level
        {
            get => level;
            private set => level = value;
        }

        public string Name
        {
            get => name;
            private set => name = value;
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

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Druid(string name, int level, int health = DEFAULT_HEALTHPOINTS, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            HealthPoints = health;
            AbilityPoints = ability;
            Faction = Faction.Mage;
            RodOfLife = new Staff();
            BarkSkinLeatherVest = new LightLeatherVest();
        }
    }
}