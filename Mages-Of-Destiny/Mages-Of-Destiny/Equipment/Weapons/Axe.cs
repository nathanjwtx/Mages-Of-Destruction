namespace Mages_Of_Destiny.Equipment.Weapons
{
    public class Axe
    {
        private int damage;
        private int hacknslash;

        public int Attack
        {
            get { return this.damage; }
        }

        public int HackNSlash
        {
            get { return this.hacknslash; }
        }

        public Axe()
        {
            this.damage = 15;
            this.hacknslash = 19;
        }
    }
}