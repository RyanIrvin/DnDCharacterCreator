﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    abstract public class Elf : IRace
    {
        public Ability AbilityModifier => new Ability(dexterity: 2);

        public Size Size => Size.Medium;

        public Alignment[] AlignmentRestriction => null;

        public Proficiency[] Proficiencies => new Proficiency[] { };

        public int Speed => 30;

        public Language[] Languages => new Language[] { Language.Common, Language.Elvish };
    }
}
