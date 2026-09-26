using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheSkywalkerSaga : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Skywalker Saga";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "KH7P320", Description = "Aayla Secure" },
                new CheatCode { Code = "XV4WND9", Description = "Admiral Holdo" },
                new CheatCode { Code = "C3PHOHO", Description = "C-3PO (Holiday Special)" },
                new CheatCode { Code = "WOOKIEE", Description = "Chewbacca (Holiday special)" },
                new CheatCode { Code = "TIPYIPS", Description = "D-O (Holiday special)" },
                new CheatCode { Code = "WROSHYR", Description = "Darth Vader (Holiday special)" },
                new CheatCode { Code = "OKV7TLR", Description = "Dengar" },
                new CheatCode { Code = "SIDIOUS", Description = "Emperor Palpatine" },
                new CheatCode { Code = "LIFEDAY", Description = "Gonk Droid (Holiday Special)" },
                new CheatCode { Code = "3FCPPVX", Description = "Grand Moff Tarkin" },
                new CheatCode { Code = "BAC1CKP", Description = "Mr Bones" },
                new CheatCode { Code = "WBFE4GO", Description = "Nute Gunray" },
                new CheatCode { Code = "KORDOKU", Description = "Poe Dameron (Holiday special)" },
                new CheatCode { Code = "Z55T8CQ", Description = "Poggle the Lesser" },
                new CheatCode { Code = "GR2VBXF", Description = "Ratts Tyerell" },
                new CheatCode { Code = "SHUTTLE", Description = "Resistance Intersystem Transport Ship" },
                new CheatCode { Code = "VT1LFNH", Description = "Shaak Ti" },
                new CheatCode { Code = "T9LM1QF", Description = "Shmi Skywalker" },
                new CheatCode { Code = "SKYSAGA", Description = "Snap Wexley" },
                new CheatCode { Code = "ARVALA7", Description = "The Razor Crest" },
            };
    }
}
