using CharacterRepository.Components.CharacterStatistics;

namespace CharacterRepository.Components
{
    public class CharacterSheet
    {
        public int Id;

        public string Name;
        public string Player;
        public string System;

        public CharacterAttributes baseCharacterAttributes;
        public int[] lHostAttributes;

        public LHost sleeve;

        //TODO Add more character attributes
    }
}
