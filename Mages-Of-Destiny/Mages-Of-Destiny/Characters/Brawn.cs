using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public class Brawn : Characters
    {
        private int _abilityPoints;

        public virtual int AbilityPoints
        {
            get => _abilityPoints;
            set => _abilityPoints = value;
        }

        public Brawn()
        {}
        
        public Brawn(int ability)
        {
            _abilityPoints = ability;
        }

        public Brawn(int health, int level, string name, Faction faction)
            : base(health, level, name, faction)
        {
            
        }
    }
}