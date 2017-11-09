namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Staff
    {
        private int damage;

        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int UseEmpower()
        {
            this.damage = 15;
            return damage;
        }

        public Staff()
        {
            damage = 10;
        }
    }
}