using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class Human : IRace, ISubrace
    {
        public Ability AbilityModifier => new Ability(1,1,1,1,1,1);

        public Size Size => Size.Medium;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => null;

        public int Speed => 30;

        public Language[] Languages => new Language[] { Language.Common }; //+1 other language
    }
}
