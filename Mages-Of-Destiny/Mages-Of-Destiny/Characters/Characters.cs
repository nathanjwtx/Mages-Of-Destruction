using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public class Character
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
        
        
    }
}