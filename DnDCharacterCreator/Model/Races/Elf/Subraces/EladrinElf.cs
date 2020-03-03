using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class EladrinElf: Elf, ISubrace
    {
        private Ability Ability = new Ability(intelligence: 1);

        public new Ability AbilityModifier => Ability += base.AbilityModifier;
    }
}
