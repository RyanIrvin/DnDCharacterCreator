using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class Dwarf : IRace
    {
        public Ability AbilityModifier => new Ability(constitution: 2);

        public Size Size => Size.Medium;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => null;

        public int Speed => 25;

        public Language[] Languages => null;
    }
}
