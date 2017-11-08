using System;

namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Sword
    {
        private int damage;
        private int BloodThirst;

        public int Damage
        {
            get { return damage; }
//            set { this.damage = value; }
        }

        public int Bloodthirst
        {
            get { return BloodThirst; }
//            set { this.BloodThirst = value; }
        }

        public Sword()
        {
            this.BloodThirst = 15;
            this.damage = 10;
        }
    }
}