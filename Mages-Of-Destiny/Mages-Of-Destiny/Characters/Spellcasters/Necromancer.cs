using Mages_Of_Destiny.Equipment.Armors;
using Mages_Of_Destiny.Equipment.Weapons;

namespace Mages_Of_Destiny.Characters.Spellcasters
{
    public class Necromancer
    {
        private int abilityPoints;
        private string faction;
        private int healthPoints;
        private int level;
        private string name;
        private Sword sword = new Sword();
        private LightLeatherVest vest = new LightLeatherVest();

        public Sword DeathBane => sword;
        public LightLeatherVest WraithShield => vest;

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
        {
            this.abilityPoints = 10;
            this.healthPoints = 20;
        }
    }
}