using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoMarvelSuperHeroes : AbstractGame
    {
        public override string Title { get; } = "Lego Marvel Super Heroes";

        public override IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "5T3CQU", Description = "Avenging Cycle" },
                new CheatCode { Code = "KXFQ87", Description = "Beetle" },
                new CheatCode { Code = "P9OWL0", Description = "Black Cat" },
                new CheatCode { Code = "7HWU4L", Description = "Captain America (Classic)" },
                new CheatCode { Code = "AA0Z50", Description = "Carnage" },
                new CheatCode { Code = "H8CSE6", Description = "Classic Thor" },
                new CheatCode { Code = "J58RSS", Description = "Howard the Duck" },
                new CheatCode { Code = "B7AA3K", Description = "Hydra Soldier" },
                new CheatCode { Code = "2NGSRZ", Description = "Iron Man (Mark 17 - Heart Breaker)" },
                new CheatCode { Code = "CK7SDS", Description = "Iron Man (Mark 38 - Hulkbuster)" },
                new CheatCode { Code = "Q5X1J5", Description = "Iron Patriot" },
                new CheatCode { Code = "SZ8Q06", Description = "MODOK" },
                new CheatCode { Code = "35E41W", Description = "Pumkin Chopper" },
                new CheatCode { Code = "D5B7O3", Description = "SHIELD Staff Car" },
                new CheatCode { Code = "SH9MZQ", Description = "Spider Bike" },
                new CheatCode { Code = "WFOZXQ", Description = "Spider-Man (Future Foundation)" },
                new CheatCode { Code = "UZFBG4", Description = "Studs x2" },
                new CheatCode { Code = "TQ4C57", Description = "War Machine" },
                new CheatCode { Code = "OAW2LB", Description = "Wolverine (with cowl)" },
            };
    }
}
