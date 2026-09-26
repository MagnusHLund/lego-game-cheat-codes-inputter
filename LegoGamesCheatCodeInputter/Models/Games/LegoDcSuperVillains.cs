using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoDcSuperVillains : IGame
    {
        public string Title { get; } = "Lego DC Super-Villains";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "QF7NT", Description = "Adam Strange" },
                new CheatCode { Code = "9RHJJ", Description = "Atrocitus" },
                new CheatCode { Code = "ND6AL", Description = "Black Canary" },
                new CheatCode { Code = "8VV5Q", Description = "Blue Beetle" },
                new CheatCode { Code = "Z6AU7", Description = "Clock King" },
                new CheatCode { Code = "BQWSG", Description = "Detective Chimp" },
                new CheatCode { Code = "KFLQM", Description = "Dex-Starr" },
                new CheatCode { Code = "KPTCC", Description = "Doctor Fate" },
                new CheatCode { Code = "6NWX5", Description = "Doctor Light" },
                new CheatCode { Code = "GWWBS", Description = "Doctor Poison" },
                new CheatCode { Code = "HFMHM", Description = "Firestorm" },
                new CheatCode { Code = "D8577", Description = "General Zod" },
                new CheatCode { Code = "KNJ2P", Description = "Green Lantern (John Stewart)" },
                new CheatCode { Code = "LNSB9", Description = "Hawkgirl" },
                new CheatCode { Code = "S5DB6", Description = "Jessica Cruz" },
                new CheatCode { Code = "XQP2L", Description = "Lady Shiva" },
                new CheatCode { Code = "Y7MFR", Description = "Martian Manhunter" },
                new CheatCode { Code = "GM9MX", Description = "Monsieur Mallah" },
                new CheatCode { Code = "NURPU", Description = "Mr. Mxyzptik" },
                new CheatCode { Code = "E6HUY", Description = "Plastic Man" },
                new CheatCode { Code = "UVWHS", Description = "Ravager" },
                new CheatCode { Code = "JNLPY", Description = "Red Robin" },
                new CheatCode { Code = "CKDRF", Description = "Red Tornado" },
                new CheatCode { Code = "QD2GY", Description = "Star Stapphire" },
                new CheatCode { Code = "F79GU", Description = "Terra" },
                new CheatCode { Code = "VB5AS", Description = "Toyman" },
                new CheatCode { Code = "YRZMS", Description = "Trickster" },
            };
    }
}
