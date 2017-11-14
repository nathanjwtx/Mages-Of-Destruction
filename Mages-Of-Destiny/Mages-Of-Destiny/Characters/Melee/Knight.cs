using System;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Melee
{
    public class Knight : Brawn
    {
        private const string DEFAULT_NAME = "Bob";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 10;
        private int _abilityPoints;
        private int _healthPoints;
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

        public override int AbilityPoints
        {   get => _abilityPoints;
            set
            {
                if (value > 4)
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
                if (value > 150)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points set too low");
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
        
        public Knight(int ability)
            : base(ability)
        {}
        
        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {}
        
        public Knight(string name, int level, int health = DEFAULT_HEALTHPOINTS, int ability = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            _abilityPoints = ability;
            Faction = Faction.Melee;
            DeathBringer = new Sword();
            BodyArmor = new Chainlink();
        }

    }
}