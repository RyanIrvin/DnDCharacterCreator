using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class Elf : IRace
    {
        public Ability AbilityModifier { get => new Ability(dexterity: 2); }
        public Size Size { get => Size.Medium; }
        public Alignment[] AlignmentRestriction { get => new Alignment[] { }; }
        public Proficiency[] Proficiencies { get => new Proficiency[] { }; }
        public int Speed { get => 30; }
    }
}
