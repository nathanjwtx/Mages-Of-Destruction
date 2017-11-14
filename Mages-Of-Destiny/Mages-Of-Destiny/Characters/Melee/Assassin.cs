using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Assassin : Brawn
    {
        private const string DEFAULT_NAME = "Frank";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 10;
        private const int DEFAULT_ABILITYPOINTS = 6;

        private LightLeatherVest bodyArmor;
        private Sword weapon;
        private int _abilityPoints;
        private int _healthPoints;

        public override int AbilityPoints
        {   get => _abilityPoints;
            set
            {
                if (value < 6)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points set too low");
                }
            }
        }

        public override int HealthPoints
        {
            get => _healthPoints;
            set
            {
                if (value > 140)
                {
                    _healthPoints = value;   
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points set too low");
                }
            }
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

        public Assassin(int ability)
            : base(ability)
        {
        }
        
        public Assassin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {
        }

        public Assassin(string name, int level, int health = DEFAULT_HEALTHPOINTS, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            Faction = Faction.Melee;
            _abilityPoints = ability;
            BodyArmor = new LightLeatherVest();
            BloodDrinker  = new Sword();
        }
    }
}