﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class LightfootHalfling : Halfling, ISubrace
    {
        private Ability Ability = new Ability(charisma: 1);

        public new Ability AbilityModifier => Ability += AbilityModifier;
    }
}
