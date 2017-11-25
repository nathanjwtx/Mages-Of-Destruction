using System;
using System.ComponentModel;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Necromancer : Brains
    {
        private const string DEFAULT_NAME = "Bill";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_ABILITYPOINTS = 9;
        private int _abilityPoints;
        private int _healthPoints;
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

        public override int HealthPoints
        {
            get => _healthPoints;
            set
            {
                if (value > 110)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Health too low");
                }
            }
        }

        public override int AbilityPoints
        {
            get => _abilityPoints;
            set
            {
                if (value > 5)
                {
                    _abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Ability too low");
                }
            }
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

        public Necromancer(int ability)
            : base(ability)
        {}
        
        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS, DEFAULT_ABILITYPOINTS)
        {
        }
        
        public Necromancer(string name, int level, int health = DEFAULT_HEALTHPOINTS, int abilityPoints = DEFAULT_ABILITYPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            _abilityPoints = abilityPoints;
            DeathBane = new Sword();
            WraithShield = new LightLeatherVest();
            Faction = Faction.Mage;
        }
    }
}