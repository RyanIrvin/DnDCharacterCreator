﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class HighElf : Elf, ISubRace
    {
        private Ability Ability = new Ability(intelligence: 1);

        public Ability AbilityModifier => Ability += base.AbilityModifier;
    }
}