using Interfaces;
using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public abstract class Character: IAttack
    {
        private int _healthPoints;
        
        public string Name { get; set; }

        public int Level { get; set; }

        public virtual int HealthPoints
        {
            get => _healthPoints; 
            set => _healthPoints = value;
        }

        public Faction Faction { get; set; }

        public Character()
        {}

        public Character(int health, int level, string name, Faction faction)
        {
            _healthPoints = health;
            Level = level;
            Name = name;
            Faction = faction;
        }


        public abstract void Attack();

        public abstract void SpecialAttack();
    }
}