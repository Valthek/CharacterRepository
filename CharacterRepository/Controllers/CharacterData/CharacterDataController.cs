﻿using System;
using System.Collections.Generic;
using System.Linq;
using CharacterRepository.Components;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("[action]")]
        public IEnumerable<CharacterSheet> CharacterSheets()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CharacterSheet
            {
                Name = Names[rng.Next(Names.Length)],
                Player = "Valthek",
                System = Systems[rng.Next(Systems.Length)]
            });
        }
    }
}