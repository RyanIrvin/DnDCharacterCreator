using System;
using System.Collections.Generic;

namespace DnDCharacterCreator.Model
{
    public class Ability
    {
        private int Strength;
        private int Dexterity;
        private int Constitution;
        private int Intelligence;
        private int Wisdom;
        private int Charisma;
        private List<int> StandardArray = new List<int> { 8, 10, 12, 13, 14, 15 };

        public Ability() { }

        public Ability(int strength = 0, int dexterity = 0, int constitution = 0, int intelligence = 0, int wisdom = 0, int charisma = 0)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public string GetAbilities()
        {
            return $"Str:{Strength}\nDex:{Dexterity}\nCon:{Constitution}\nInt:{Intelligence}\nWis:{Wisdom}\nCha:{Charisma}";
        }

        public void AddStat(ref int stat, int amount)
        {
            stat += amount;
        }

        public List<int> GetStandardArray(int removeValue = 0)
        {
            if (removeValue != 0)
                StandardArray.Remove(removeValue);
            return StandardArray;
        }

        public static Ability operator +(Ability ability1, Ability ability2)
        {
            return new Ability(ability1.Strength + ability2.Strength,
                ability1.Dexterity + ability2.Dexterity,
                ability1.Constitution + ability2.Constitution,
                ability1.Intelligence + ability2.Intelligence,
                ability1.Wisdom + ability2.Wisdom,
                ability1.Charisma + ability2.Charisma);
        }
    }
}