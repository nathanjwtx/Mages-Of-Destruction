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

        public int AbilityPoints { get; set; }
        public string Faction { get; set; }
        public int HealthPoints { get; set; }
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
    }
}