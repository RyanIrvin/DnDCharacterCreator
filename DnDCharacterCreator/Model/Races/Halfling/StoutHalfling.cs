using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class StoutHalfling
    {
        private Ability Ability = new Ability(constitution: 1);

        public new Ability AbilityModifier => Ability += AbilityModifier;
    }
}
