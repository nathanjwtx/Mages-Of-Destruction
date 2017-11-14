using System.Collections.ObjectModel;
using Mages_Of_Destiny.Enums;

namespace Mages_Of_Destiny.Characters
{
    public class Brains : Characters
    {
        private int _abilityPoints;

        public virtual int AbilityPoints
        { get; set; }

        public Brains()
        {}

        public Brains(int ability)
        {
            _abilityPoints = ability;
        }

        public Brains(int health, int level, string name, Faction faction)
            : base(health, level, name, faction)
        {}
    }
}