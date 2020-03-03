using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{ 
    class ForestGnome: Gnome, ISubrace
    {
        private Ability Ability = new Ability(dexterity: 1);

        public new Ability AbilityModifier => Ability += base.AbilityModifier;
    }
}
