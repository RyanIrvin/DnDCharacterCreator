namespace DnDCharacterCreator.Model.Races
{
    public interface ISubRace : IRace
    {
        new Ability AbilityModifier { get; }

        new Proficiency[] Proficiencies { get; }
    }
}