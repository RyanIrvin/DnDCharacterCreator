using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class HillDwarf : Dwarf, ISubrace
    {
        private Ability Abilities = new Ability(wisdom: 1);

        public new Ability AbilityModifier => Abilities += base.AbilityModifier;
    }
}