using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class WoodElf: Elf, ISubRace
    {
        private Ability Ability = new Ability(wisdom: 1);

        public Ability AbilityModifier => Ability += base.AbilityModifier;
    }
}
