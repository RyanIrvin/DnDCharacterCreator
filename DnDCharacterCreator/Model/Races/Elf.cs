using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    abstract public class Elf : IRace
    {
        internal Ability BaseAbilities = new Ability(dexterity: 2);

        internal Proficiency[] BaseProficiencies = new Proficiency[] { };

        public Ability AbilityModifier => BaseAbilities;

        public Size Size => Size.Medium;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => BaseProficiencies;

        public int Speed => 30;

        public Language[] Languages => new Language[] { Language.Common, Language.Elvish };
    }
}
