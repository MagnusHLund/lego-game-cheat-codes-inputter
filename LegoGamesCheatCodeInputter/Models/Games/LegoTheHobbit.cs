using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoTheHobbit : IGame
    {
        public string Title { get; } = "Lego The Hobbit";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "FAVZTR", Description = "Alfrid" },
                new CheatCode { Code = "84ZZSI", Description = "Azog (Claw)" },
                new CheatCode { Code = "W5Z6AC", Description = "Bain" },
                new CheatCode { Code = "UER3JG", Description = "Bard" },
                new CheatCode { Code = "XTVM8C", Description = "Barliman Butterbur" },
                new CheatCode { Code = "555R9C", Description = "Barrow Wight" },
                new CheatCode { Code = "KEID2V", Description = "Beorn" },
                new CheatCode { Code = "ZIBYHO", Description = "Bolg (the O is the letter o)" },
                new CheatCode { Code = "MXUXKO", Description = "Braga (the O is the letter o)" },
                new CheatCode { Code = "H2CAID", Description = "Elros" },
                new CheatCode { Code = "THAVRM", Description = "Fimbul" },
                new CheatCode { Code = "00TE7J", Description = "Galadriel (the two 0′s are the numbers zero)" },
                new CheatCode { Code = "3CE37P", Description = "Gollum" },
                new CheatCode { Code = "TPD7YW", Description = "Grinnah" },
                new CheatCode { Code = "V4Y5HZ", Description = "Lindir" },
                new CheatCode { Code = "9NOK35", Description = "Master Of Laketown (the O is the letter o)" },
                new CheatCode { Code = "4FYKKB", Description = "Narzug" },
                new CheatCode { Code = "NM3I2O", Description = "Necromancer (the O is the letter o)" },
                new CheatCode { Code = "74KN31", Description = "Percy" },
                new CheatCode { Code = "5OJEUC", Description = "Peter Jackson (Bree) (the O is the letter o)" },
                new CheatCode { Code = "TB4S6J", Description = "Rosie Cotton" },
                new CheatCode { Code = "OARA3D", Description = "Sauron (the O is the letter o)" },
                new CheatCode { Code = "SYKSXF", Description = "Thror (Armour)" },
                new CheatCode { Code = "4Y95TJ", Description = "Tom Bombadil" },
                new CheatCode { Code = "V8AHMJ", Description = "Witch-king" },
                new CheatCode { Code = "S6VV33", Description = "Yazneg" },
            };
    }
}
