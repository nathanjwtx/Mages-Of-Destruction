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
        private int _healthPoints;
        private int _mana;
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

        public Necromancer(int mana)
            : base(mana)
        {}
        
        public Necromancer()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS)
        {
        }
        
        public Necromancer(string name, int level, int health = DEFAULT_HEALTHPOINTS)
        {
            Name = name;
            Level = level;
            _healthPoints = health;
            DeathBane = new Sword();
            WraithShield = new LightLeatherVest();
            Faction = Faction.Mage;
        }
    }
}