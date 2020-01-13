using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class Halfling : IRace
    {
        public Ability AbilityModifier => new Ability(dexterity: 2);

        public Size Size => Size.Small;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => null;

        public int Speed => 20;

        public Language[] Languages => new Language[] { Language.Common, Language.Halfling };
    }
}