
using System.Collections.Generic;

namespace CharacterRepository.Components.CharacterStatistics
{ 
    public interface CharacterAttributes
    {

        List<string> GetAttributeNames();

        List<int> GetAttributeValues();
    }
}
