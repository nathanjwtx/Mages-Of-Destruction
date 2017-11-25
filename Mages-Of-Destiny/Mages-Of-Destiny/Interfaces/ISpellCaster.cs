using System;
using System.Collections.Generic;
using System.Text;
using Mages_Of_Destiny.Characters;
using Mages_Of_Destiny.Characters.Melee;
using Mages_Of_Destiny.Characters.Spellcasters;

namespace Interfaces
{
    public interface ISpellCaster
    {
        int Mana { get; set; }

        void CastSpell(Character mage, int spellDamge);
    }
}
