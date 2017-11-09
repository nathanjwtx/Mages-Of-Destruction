namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Hammer
    {
        private int damage;

        public int Attack
        {
            get { return damage; }
            set { damage = value; }
        }

        public int Stun()
        {
            damage = 18;
            return this.damage;
        }

        public Hammer()
        {
            this.damage = 12;
        }
    }
}