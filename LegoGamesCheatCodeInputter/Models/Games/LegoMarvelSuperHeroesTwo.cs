using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoMarvelSuperHeroesTwo : IGame
    {
        public string Title { get; } = "Lego Marvel Super Heroes 2";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "JDNQMV", Description = "Loki" },
                new CheatCode { Code = "HCE926", Description = "Maestro" },
                new CheatCode { Code = "BCR7QJ", Description = "Ant-Man" },
                new CheatCode { Code = "G6K2VM", Description = "Hawkeye" },
                new CheatCode { Code = "NCMJU4", Description = "Hellcow" },
                new CheatCode { Code = "UUTZNC", Description = "Militant" },
                new CheatCode { Code = "D6LJ4P", Description = "Songbird" },
                new CheatCode { Code = "S947TP", Description = "Darkstar" },
                new CheatCode { Code = "5G7HFS", Description = "Hulkling" },
                new CheatCode { Code = "HL7L7Y", Description = "Ragnarok" },
                new CheatCode { Code = "GAVK9R", Description = "Giant-Man" },
                new CheatCode { Code = "BK9B3Y", Description = "Misty Knight" },
                new CheatCode { Code = "CW9BRS", Description = "Spider-Woman" },
                new CheatCode { Code = "XG7SAL", Description = "Green Goblin" },
                new CheatCode { Code = "RMADXF", Description = "Spider-Man UK" },
                new CheatCode { Code = "CDS278", Description = "Crimson Dynamo" },
                new CheatCode { Code = "8KD3F6", Description = "Winter Soldier" },
                new CheatCode { Code = "JD9GQA", Description = "Scarlet Spider" },
                new CheatCode { Code = "M68P3L", Description = "Captain Britain" },
                new CheatCode { Code = "4U9DAT", Description = "Vision (Civil War)" },
                new CheatCode { Code = "QG3VH9", Description = "Baby Groot (Ravager)" },
                new CheatCode { Code = "7KDY3L", Description = "Vulture (Homecoming)" },
                new CheatCode { Code = "LBYT59", Description = "Grandmaster (Ragnarok)" },
            };
    }
}
