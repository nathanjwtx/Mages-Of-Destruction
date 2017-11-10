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
        {
            this.abilityPoints = 10;
            this.healthPoints = 20;
        }
    }
}