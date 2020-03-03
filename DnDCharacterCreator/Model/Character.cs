using DnDCharacterCreator.Model.Races;

namespace DnDCharacterCreator.Model
{
    public class Character
    {

        private string Name;
        private int Speed;
        private Size Size;
        public Alignment Alignment;
        public Ability Ability = new Ability();
        private IRace Race;
        private int Level = 0;
        public Class[] Class;
        public Feat[] Feat;
        public Proficiency[] Proficiency;
        public Item[] Inventory;
        public Skill[] Skill;
        public string GetName() => Name;
        public int GetSpeed() => Speed;
        public int GetLevel() => Level;
        public Size GetSize() => Size;
        public IRace GetRace() => Race;
        public void SetName(string value) => Name = value;
        public void SetRace(ISubrace value)
        {
            Race = value;
            Ability += value.AbilityModifier;
            Speed = value.Speed;
            Size = value.Size;
        }

        public Character() { }
    }
}