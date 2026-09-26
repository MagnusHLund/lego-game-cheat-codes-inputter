using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoJurassicWorld : IGame
    {
        public string Title { get; } = "Lego Jurassic World";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "AU25GR", Description = "ACU Trooper (Female)" },
                new CheatCode { Code = "28SPSR", Description = "ACU Trooper (Male)" },
                new CheatCode { Code = "VK3TP3", Description = "Carlos" },
                new CheatCode { Code = "9GESXP", Description = "Carter" },
                new CheatCode { Code = "5BETZ5", Description = "Cooper" },
                new CheatCode { Code = "RAVKRT", Description = "Dennis Nedry (Costa Rica)" },
                new CheatCode { Code = "EKCKLC", Description = "Dieter Stark" },
                new CheatCode { Code = "YQ6S7Z", Description = "Dino Handler Vic or Bob" },
                new CheatCode { Code = "AV9DTJ", Description = "Ellie Degler" },
                new CheatCode { Code = "9NGZZQ", Description = "Gyrosphere Operator Josh" },
                new CheatCode { Code = "A3HC7E", Description = "Henry Wu (Jurassic World)" },
                new CheatCode { Code = "QKBCWT", Description = "InGen Guard Jerry" },
                new CheatCode { Code = "38YWVR", Description = "InGen Hunter" },
                new CheatCode { Code = "RMVVB8", Description = "InGen Mechanic (InGen Hunter)" },
                new CheatCode { Code = "VZRSD3", Description = "InGen Mercenary (InGen Contractor)" },
                new CheatCode { Code = "8XL359", Description = "InGen Scout (InGen Hunter 1)" },
                new CheatCode { Code = "6MKHSG", Description = "Jimmy Fallon" },
                new CheatCode { Code = "PR2R6Y", Description = "John Hammond (Lost World)" },
                new CheatCode { Code = "XTH9A3", Description = "Juanito Rostagno" },
                new CheatCode { Code = "3FE78R", Description = "Jurassic Park Driver (Jeep Driver)" },
                new CheatCode { Code = "8WY3FV", Description = "Jurassic Park Warden (Female)" },
                new CheatCode { Code = "XJS7UY", Description = "Jurassic Park Warden (Male)" },
                new CheatCode { Code = "BX9Z6R", Description = "Jurassic World Paddock Worker" },
                new CheatCode { Code = "GW9TGH", Description = "Jurassic World Ranger" },
                new CheatCode { Code = "L5AU6Y", Description = "Jurassic World Worker (Jurassic World Ranger) (Female)" },
                new CheatCode { Code = "JYJAFX", Description = "Minikit Detector" },
                new CheatCode { Code = "BRLNWC", Description = "Nash (Runway)" },
                new CheatCode { Code = "SXZ7CC", Description = "Raptor Handler Jenny" },
                new CheatCode { Code = "62539J", Description = "S.S. Venture Crewman" },
                new CheatCode { Code = "XVXGXF", Description = "Scientist (Female)" },
                new CheatCode { Code = "SKKLWC", Description = "Scientist (Male)" },
                new CheatCode { Code = "5MZ73E", Description = "Studs Score Multiplier x 2" },
                new CheatCode { Code = "PFEBS6", Description = "Udesky (Alt)" },
                new CheatCode { Code = "7VNLJT", Description = "Young Raptor Handler from Jurassic World" },
            };
    }
}
