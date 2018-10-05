using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CharacterRepository.Components.CharacterStatistics
{
    public class InfinityCharacterAttributes : ICharacterAttributes
    {
        public int Agility;
        public int Awareness;
        public int Brawn;
        public int Coordination;
        public int Personality;
        public int Intelligence;
        public int Willpower;

        public List<string> GetAttributeNames()
        {
            List<string> names = new List<string>();
            foreach (PropertyInfo prop in typeof(InfinityCharacterAttributes).GetProperties())
            {
                names.Add(prop.Name);
            }
            return names;
        }

        public List<int> GetAttributeValues()
        {
            List<int> attributes = new List<int>();
            foreach (PropertyInfo prop in typeof(InfinityCharacterAttributes).GetProperties())
            {
                attributes.Add(int.Parse(prop.GetValue(this, null).ToString()));
            }
            return attributes;
        }
    }
}
