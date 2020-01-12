using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    public class DarkElf : Elf, ISubRace
    {
        private Ability Abilities = new Ability(charisma: 1);

        public new Ability AbilityModifier => BaseAbilities += Abilities;
    }
}
