using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Staff staff = new Staff();
        private ClothRobe robe = new ClothRobe();

        public Staff RodOfElectricity => staff;
        public ClothRobe RobeOfIllumination => robe;

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

        public Mage()
        {
            this.abilityPoints = 10;
            this.healthPoints = 20;
        }
    }
}