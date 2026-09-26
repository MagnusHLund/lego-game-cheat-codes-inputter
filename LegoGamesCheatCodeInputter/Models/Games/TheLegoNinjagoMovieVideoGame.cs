using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class TheLegoNinjagoMovieVideoGame : IGame
    {
        public string Title { get; } = "The Lego Ninjago Movie Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "SMMNCC", Description = "Cole (High School)" },
                new CheatCode { Code = "LLPQ6X", Description = "Garmadon (Pajamas)" },
                new CheatCode { Code = "EFZ2XR", Description = "General #1" },
                new CheatCode { Code = "733FW8", Description = "Hot Dog Man" },
                new CheatCode { Code = "BFJPNE", Description = "IT Bat Nerd" },
                new CheatCode { Code = "XVTULS", Description = "Jay (High School)" },
                new CheatCode { Code = "2WYU16", Description = "Kai (High School)" },
                new CheatCode { Code = "2W9UFG", Description = "Kai (Training)" },
                new CheatCode { Code = "326CG6", Description = "Koko" },
                new CheatCode { Code = "D9TZ39", Description = "Lloyd (Hoodie)" },
                new CheatCode { Code = "H7HGT3", Description = "Lloyd (Kendo)" },
                new CheatCode { Code = "5AGF4Y", Description = "Master Wu" },
                new CheatCode { Code = "8755Q9", Description = "Nya (Ceremonial Robes)" },
                new CheatCode { Code = "9R37MR", Description = "Shark Army General #1" },
                new CheatCode { Code = "KU92UG", Description = "Sushi Chef" },
                new CheatCode { Code = "5NHRS5", Description = "Zane (High School)" },
            };
    }
}
