using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheForceAwakens : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Force Awakens";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "QLLJXD", Description = "B-U4D" },
                new CheatCode { Code = "26F2CF", Description = "Caluan Ematt" },
                new CheatCode { Code = "BQPKPA", Description = "Crokind Shand" },
                new CheatCode { Code = "BJZA6F", Description = "Dasha Promenti" },
                new CheatCode { Code = "LRYUBB", Description = "Flametrooper" },
                new CheatCode { Code = "4T3UNK", Description = "FN-2112" },
                new CheatCode { Code = "3RRVAV", Description = "FN-2187 (without helmet)" },
                new CheatCode { Code = "2YU4NX", Description = "Geetaw (GTAW-74)" },
                new CheatCode { Code = "QZTZX9", Description = "Goss Toowers" },
                new CheatCode { Code = "C73CNV", Description = "Guavian Security Soldier" },
                new CheatCode { Code = "E889GQ", Description = "Hobin Carsamba" },
                new CheatCode { Code = "V3H6RU", Description = "Hoogenz" },
                new CheatCode { Code = "SBUSCW", Description = "Jessika Pava" },
                new CheatCode { Code = "9FJKF4", Description = "Kaydel Ko Connix" },
                new CheatCode { Code = "NGSEKH", Description = "Korr Sella" },
                new CheatCode { Code = "XQZ7C6", Description = "Lieutenant Bastian" },
                new CheatCode { Code = "Q8KRC6", Description = "Major Brance" },
                new CheatCode { Code = "GBE8ZC", Description = "Mi'no Teest" },
                new CheatCode { Code = "A5JR9V", Description = "Monn Tatth" },
                new CheatCode { Code = "P8KXSA", Description = "Nien Nunb" },
                new CheatCode { Code = "GVNBWB", Description = "Officer Sumistu" },
                new CheatCode { Code = "K6JXJT", Description = "Oskus Stooratt" },
                new CheatCode { Code = "A4EHFJ", Description = "Quinar" },
                new CheatCode { Code = "BEMT2T", Description = "R-3PO" },
                new CheatCode { Code = "VVVSEA", Description = "R2-Q5" },
                new CheatCode { Code = "HTN3RD", Description = "Snap Wexley" },
                new CheatCode { Code = "59J67X", Description = "Special Forces TIE Pilot" },
                new CheatCode { Code = "CP6ETU", Description = "Teedo" },
                new CheatCode { Code = "638FNX", Description = "Trentus Savay" },
                new CheatCode { Code = "2DZXDM", Description = "Unamo (Cheif Petty Officer)" },
                new CheatCode { Code = "YABPYU", Description = "Unkar Thug" },
                new CheatCode { Code = "J3GMHE", Description = "Wollivan" },
            };
    }
}
