using System;
using System.Collections.Generic;
using System.Text;
using Mages_Of_Destiny.Characters.Melee;

namespace Interfaces
{
    public interface ISpellCaster
    {
        int Mana { get; set; }

        void CastSpell(Warrior warrior);
    }
}
