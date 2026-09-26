using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTwoTheOriginalTrilogy : IGame
    {
        public string Title { get; } = "Lego Star Wars II: The Original Trilogy";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "UCK868", Description = "Beach Trooper" },
                new CheatCode { Code = "BEN917", Description = "Ben Kenobi (Ghost)" },
                new CheatCode { Code = "VHY832", Description = "Bespin Guard" },
                new CheatCode { Code = "WTY721", Description = "Bib Fortuna" },
                new CheatCode { Code = "HLP221", Description = "Boba Fett" },
                new CheatCode { Code = "BNC332", Description = "Death Star Trooper" },
                new CheatCode { Code = "TTT289", Description = "Ewok" },
                new CheatCode { Code = "YZF999", Description = "Gamorrean Guard" },
                new CheatCode { Code = "NFX582", Description = "Gonk Droid" },
                new CheatCode { Code = "SMG219", Description = "Grand Moff Tarkin" },
                new CheatCode { Code = "PRJ821", Description = "Greedo" },
                new CheatCode { Code = "YWM840", Description = "Han Solo (Hood)" },
                new CheatCode { Code = "NXL973", Description = "IG-88" },
                new CheatCode { Code = "MMM111", Description = "Imperial Guard" },
                new CheatCode { Code = "BBV889", Description = "Imperial Officer" },
                new CheatCode { Code = "VAP664", Description = "Imperial Shuttle Pilot" },
                new CheatCode { Code = "CVT125", Description = "Imperial Spy" },
                new CheatCode { Code = "JAW499", Description = "Jawa" },
                new CheatCode { Code = "UUB319", Description = "Lobot" },
                new CheatCode { Code = "SGE549", Description = "Palace Guard" },
                new CheatCode { Code = "CYG336", Description = "Rebel Pilot" },
                new CheatCode { Code = "EKU849", Description = "Rebel Trooper (Hoth)" },
                new CheatCode { Code = "NBP398", Description = "Red noses on all characters" },
                new CheatCode { Code = "YDV451", Description = "Sandtrooper" },
                new CheatCode { Code = "CL4U5H", Description = "Santa hat & clothes" },
                new CheatCode { Code = "GBU888", Description = "Skiff Guard" },
                new CheatCode { Code = "NYU989", Description = "Snow Trooper" },
                new CheatCode { Code = "TYH319", Description = "the beard" },
                new CheatCode { Code = "HHY382", Description = "The Emperor" },
                new CheatCode { Code = "HDY739", Description = "TIE Fighter" },
                new CheatCode { Code = "NNZ316", Description = "TIE Fighter Pilot" },
                new CheatCode { Code = "QYA828", Description = "TIE Interceptor" },
                new CheatCode { Code = "NAH118", Description = "Tusken Raider" },
                new CheatCode { Code = "UGN694", Description = "Ugnaught" },
            };
    }
}
