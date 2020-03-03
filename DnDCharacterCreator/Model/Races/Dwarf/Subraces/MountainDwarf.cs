using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class MountainDwarf : Dwarf, ISubrace
    {
        private Ability Abilities = new Ability(strength: 2);

        public new Ability AbilityModifier => Abilities += base.AbilityModifier;
    }
}
