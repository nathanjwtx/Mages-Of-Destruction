using System;
using System.ComponentModel;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Necromancer
    {
        private const string DEFAULT_NAME = "Bill";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Sword sword;
        private LightLeatherVest vest;

        public Sword DeathBane 
        {
            get => sword;
            set => sword = value;
        }

        public LightLeatherVest WraithShield
        {
            get => vest;
            set => vest = value;
        }

        public string Faction
        {
            get => faction;
            private set
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

        public int ShadowRage()
        {
            var damage = 13;
            return damage;
        }

        public int VampireTouch()
        {
            var damage = 15;
            return damage;
        }

        public int BoneShield()
        {
            var healthBoost = 10;
            return healthBoost;
        }

        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS)
        {}
        
        public Necromancer(string name, int level, int health = DEFAULT_HEALTHPOINTS)
        {
            Name = name;
            Level = level;
            HealthPoints = health;
            Faction = "Mage";
            AbilityPoints = 9;
            DeathBane = new Sword();
            WraithShield = new LightLeatherVest();
        }
    }
}