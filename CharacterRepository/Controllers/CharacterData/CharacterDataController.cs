using System;
using System.Collections.Generic;
using System.Linq;
using CharacterRepository.Components;
using Microsoft.AspNetCore.Mvc;
using CharacterRepository.Components.CharacterStatistics;

namespace CharacterRepository.Controllers.CharacterData
{
    [Route("api/[controller]")]
    public class CharacterDataController : Controller
    {
        private static readonly string[] Names = new[]
        {
            "Swann", "Grog", "Mickey", "Steve", "Myrtle", "Cherub", "Uni", "Twelves", "Check"
        };

        private static readonly string[] Systems = new[]
        {
            "5E", "PF2", "EP 1ed", "EP 2ed", "BitD", "P&P"
        };

        private List<CharacterSheet> _storedCharacterSheets = new List<CharacterSheet>();

        [HttpGet("[action]")]
        public IEnumerable<CharacterSheet> CharacterSheets()
        {
            var rng = new Random();

            var ourCharAttributes = new InfinityCharacterAttributes
            {
                Agility = 7,
                Awareness = 7,
                Brawn = 7,
                Coordination = 7,
                Intelligence = 7,
                Personality = 7,
                Willpower = 7
            };

            if (_storedCharacterSheets.Count <= 0)
            {
                _storedCharacterSheets = Enumerable.Range(1, 5).Select(index => new CharacterSheet
                {
                    Id = index,
                    Name = Names[rng.Next(Names.Length)],
                    Player = "Valthek",
                    System = Systems[rng.Next(Systems.Length)],
                    BaseCharacterAttributes = ourCharAttributes
                }).ToList();
            }

            return _storedCharacterSheets;
        }

        [HttpPut("[action]")]
        public void SetCharacterSheet()
        {

        }

        [HttpGet("{id}")]
        public CharacterSheet DetailCharacterSheet(int id)
        {
            return _storedCharacterSheets[id];
        }
    }
}