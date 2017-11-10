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

        public int AbilityPoints { get => this.abilityPoints; }

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

        public Knight(string faction)
        {
            this.abilityPoints = 10;
            this.healthPoints = 25;
            this.Faction = faction;
        }

    }
}