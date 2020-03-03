using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class WoodElf: Elf, ISubrace
    {
        private Ability Ability = new Ability(wisdom: 1);

        public new Ability AbilityModifier => Ability += base.AbilityModifier;
    }
}
