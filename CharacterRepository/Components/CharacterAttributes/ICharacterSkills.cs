using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterRepository.Components.CharacterStatistics
{
    interface ICharacterSkills
    {
        List<string> GetSkillNames();

        List<int> GetSkillValues();
    }
}
