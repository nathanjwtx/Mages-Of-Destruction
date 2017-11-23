using System;
using System.Dynamic;
using System.Security.Cryptography;
using Interfaces;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Enums;
using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;
using Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Mage : Brains, ISpellCaster
    {
        private const string DEFAULT_NAME = "Tim";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTHPOINTS = 12;
        private const int DEFAULT_MANA = 50;
        private int _healthPoints;
        private int _mana;
        private Staff staff;
        private ClothRobe robe;
        private Spell firstSpell;

        public Spell FirstSpell
        {
            get => firstSpell;
            set => firstSpell = value;
        }

        public Staff RodOfElectricity
        {
            get => staff;
            private set => staff = value;
        }

        public ClothRobe RobeOfIllumination
        {
            get => robe;
            private set => robe = value;
        }

        public override int HealthPoints
        {
            get => _healthPoints;
            set
            {
                if (value > 100)
                {
                    _healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Health too low");
                }
            }
        }

        public int ArcaneWrath()
        {
            var damage = 13;
            return damage;
        }

        public int Firewall()
        {
            var damage = 15;
            return damage;
        }

        public int Meditation()
        {
            var healthBoost = 10;
            return healthBoost;
        }

        public Mage(int mana)
            : base(mana)
        {
            _mana = 100;
            this.FirstSpell = new Spell();
        }
        
        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL, DEFAULT_HEALTHPOINTS)
        {}
        
        public Mage(string name, int level, int health = DEFAULT_HEALTHPOINTS, int mana = DEFAULT_MANA)
        {
//            _mana = 100;
            Name = name;
            Level = level;
            _healthPoints = health;
            _mana = mana;
            Faction = Faction.Mage;
            RodOfElectricity = new Staff();
            RobeOfIllumination = new ClothRobe();
        }

//        public int Mana
//        {
//            get => _mana;
//            set => _mana = value;
//        }

        public void CastSpell(Warrior warrior, Mage mage)
        {
            Console.WriteLine(warrior.HealthPoints);
            warrior.HealthPoints = warrior.HealthPoints - FirstSpell.Damage;
            _mana = _mana - this.FirstSpell.ManaCost;
            Console.WriteLine(warrior.HealthPoints);
            Console.WriteLine(_mana);
        }
    }
}