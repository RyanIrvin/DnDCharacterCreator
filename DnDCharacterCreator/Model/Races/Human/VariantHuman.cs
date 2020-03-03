using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterCreator.Model.Races
{
    class VariantHuman: Human, ISubrace
    {
        //+1 to two different ability scores
        private Ability Ability = new Ability(constitution: 1);

        public new Ability AbilityModifier => Ability; //overrides base Human +1 to all stats

    }
}
