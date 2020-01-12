using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    abstract public class Gnome : IRace
    {
        public Ability AbilityModifier => new Ability(intelligence: 2);

        public Size Size => Size.Small;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => new Proficiency[] { };

        public int Speed => 25;

        public Language[] Languages => new Language[] { Language.Common, Language.Gnomish };
    }
}