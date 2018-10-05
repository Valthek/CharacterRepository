
using System.Collections.Generic;

namespace CharacterRepository.Components.CharacterStatistics
{ 
    public interface ICharacterAttributes
    {

        List<string> GetAttributeNames();

        List<int> GetAttributeValues();
    }
}
