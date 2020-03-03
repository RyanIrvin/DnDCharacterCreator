namespace DnDCharacterCreator.Model.Races
{
    public interface ISubrace : IRace
    {
        new Ability AbilityModifier { get; }

        new Proficiency[] Proficiencies { get; }
    }
}