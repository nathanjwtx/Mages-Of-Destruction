namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Hammer
    {
        private int damage;
        private int stun;

        public int Attack
        {
            get { return damage; }
        }

        public int Stun
        {
            get { return stun; }
        }

        public Hammer()
        {
            this.damage = 12;
            this.stun = 17;
        }
    }
}