namespace DnDCharacterCreator.Model.Races
{
    public interface IRace
    {
        Ability AbilityModifier { get; }

        Size Size { get; }

        Alignment[] AlignmentRestriction { get; }

        Proficiency[] Proficiencies { get; }

        int Speed { get; }

        Language[] Languages { get; }
    }
}