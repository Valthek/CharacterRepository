using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;


namespace CharacterRepository.Components.CharacterStatistics
{
    public class InfinityCharacterSkills : ICharacterSkills
    {
        public int Acrobatics; //Agility
        public int Analysis;  // (Awareness)
        public int AnimalHandling; //(Personality)
        public int Athletics; // (Brawn)
        public int Ballistics; // (Coordination)
        public int CloseCombat; //(Agility)
        public int Command; // (Personality)
        public int Discipline; // (Willpower)
        public int Education; // (Intelligence)
        public int Extraplanetary; // (Awareness)
        public int Hacking; // (Intelligence)
        public int Lifestyle; // (Personality)
        public int Medicine; // (Intelligence)
        public int Observation; // (Awareness)
        public int Persuade; // (Personality)
        public int Pilot; // (Coordination)
        public int Psychology; // (Intelligence)
        public int Resistance; // (Brawn)
        public int Science; // (Intelligence)
        public int Spacecraft; // (Coordination)
        public int Stealth; // (Agility)
        public int Survival; // (Awareness)
        public int Tech; // (Intelligence)
        public int Thievery; // (Awareness)

        public List<string> GetSkillNames()
        {
            List<string> names = new List<string>();
            foreach (PropertyInfo prop in typeof(InfinityCharacterSkills).GetProperties())
            {
                names.Add(prop.Name);
            }
            return names;
        }

        public List<int> GetSkillValues()
        {
            List<int> values = new List<int>();
            foreach (PropertyInfo prop in typeof(InfinityCharacterSkills).GetProperties())
            {
                values.Add(int.Parse(prop.GetValue(this, null).ToString()));
            }
            return values;
        }
    }
}
