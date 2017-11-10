namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Staff
    {
        private int damage;
        private int empower;

        public int Damage
        {
            get { return damage; }
        }

        public int Empower
        {
            get { return empower; }
        }

        public Staff()
        {
            this.damage = 10;
            this.empower = 18;
        }
    }
}