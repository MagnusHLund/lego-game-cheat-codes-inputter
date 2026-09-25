using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoBatmanThreeBeyondGotham : IGame
    {
        public string Title { get; } = "Lego Batman 3: Beyond Gotham";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "XZKLKQ", Description = "Unlocks Bane" },
                new CheatCode { Code = "B5ABPQ", Description = "Unlocks Lobo" },
                new CheatCode { Code = "4LS32K", Description = "Unlocks Batgirl" },
                new CheatCode { Code = "V3GTHB", Description = "Unlocks Aquaman" },
                new CheatCode { Code = "95U7BM", Description = "Unlocks Giganta" },
                new CheatCode { Code = "QDQ3YL", Description = "Unlocks Superboy" },
                new CheatCode { Code = "TRQTPS", Description = "Unlocks Red Hood" },
                new CheatCode { Code = "5MZ73E", Description = "Unlocks Studs x2" },
                new CheatCode { Code = "YC3KZZ", Description = "Unlocks Beast Boy" },
                new CheatCode { Code = "ZGCEAJ", Description = "Unlocks Atrocitus" },
                new CheatCode { Code = "9WYGLP", Description = "Unlocks The Joker" },
                new CheatCode { Code = "N9CZ7S", Description = "Unlocks Nightwing" },
                new CheatCode { Code = "J6ANCT", Description = "Unlocks Kevin Smith" },
                new CheatCode { Code = "APEKBV", Description = "Unlocks Blue Beetle" },
                new CheatCode { Code = "5SW59X", Description = "Unlocks Deathstroke" },
                new CheatCode { Code = "4HRERD", Description = "Unlocks Doctor Fate" },
                new CheatCode { Code = "H2VB8Z", Description = "Unlocks Plastic Man" },
                new CheatCode { Code = "PHHGPH", Description = "Unlocks Festive Hats" },
                new CheatCode { Code = "FQ4ESE", Description = "Unlocks Frankenstein" },
                new CheatCode { Code = "S7GSDE", Description = "Unlocks Music Meister" },
                new CheatCode { Code = "KNJBD8", Description = "Unlocks Quest Detector" },
                new CheatCode { Code = "EWTPKA", Description = "Unlocks Fight Captions" },
                new CheatCode { Code = "JYJAFX", Description = "Unlocks Minikit Detector" },
                new CheatCode { Code = "NQ46RC", Description = "Unlocks The Fierce Flame" },
                new CheatCode { Code = "ZWQPJD", Description = "Unlocks Batman (Planet X, Zur-En-Arrh)" },
            };
    }
}
