using CharacterRepository.Components.CharacterStatistics;

namespace CharacterRepository.Components
{
    public class CharacterSheet
    {
        public int Id;

        public string Name;
        public string Player;
        public string System;

        public ICharacterAttributes BaseCharacterAttributes;
        public int[] LHostAttributes;

        public LHost Sleeve;

        //TODO Add more character attributes
    }
}
