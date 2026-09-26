using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoStarWarsTheVideoGame : IGame
    {
        public string Title { get; } = "Lego Star Wars: The Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "987UYR", Description = "Battle Droid" },
                new CheatCode { Code = "EN11K5", Description = "Battle Droid (Commander)" },
                new CheatCode { Code = "LK42U6", Description = "Battle Droid (Geonosis)" },
                new CheatCode { Code = "KF999A", Description = "Battle Droid (Security)" },
                new CheatCode { Code = "IG72X4", Description = "Big Blasters" },
                new CheatCode { Code = "LA811Y", Description = "Boba Fett" },
                new CheatCode { Code = "SHRUB1", Description = "Brushes" },
                new CheatCode { Code = "L449HD", Description = "Classic Blasters" },
                new CheatCode { Code = "F8B4L6", Description = "Clone" },
                new CheatCode { Code = "BHU72T", Description = "Clone (Episode III Pilot)" },
                new CheatCode { Code = "N3T6P8", Description = "Clone (Episode III Swamp)" },
                new CheatCode { Code = "RS6E25", Description = "Clone (Episode III Walker)" },
                new CheatCode { Code = "ER33JN", Description = "Clone (Episode III)" },
                new CheatCode { Code = "14PGMN", Description = "Count Dooku" },
                new CheatCode { Code = "H35TUX", Description = "Darth Maul" },
                new CheatCode { Code = "A32CAM", Description = "Darth Sidious" },
                new CheatCode { Code = "VR832U", Description = "Disguised Clone" },
                new CheatCode { Code = "DH382U", Description = "Droideka" },
                new CheatCode { Code = "SF321Y", Description = "General Grievous" },
                new CheatCode { Code = "19D7NB", Description = "Geonosian" },
                new CheatCode { Code = "U63B2A", Description = "Gonk Droid" },
                new CheatCode { Code = "ZTY392", Description = "Grievous' Bodyguard" },
                new CheatCode { Code = "4PR28U", Description = "Invincible" },
                new CheatCode { Code = "PL47NH", Description = "Jango Fett" },
                new CheatCode { Code = "DP55MV", Description = "Ki-Adi Hundi" },
                new CheatCode { Code = "CBR954", Description = "Kit Fisto" },
                new CheatCode { Code = "A725X4", Description = "Luminara" },
                new CheatCode { Code = "MS952L", Description = "Mace Windu (Episode III)" },
                new CheatCode { Code = "LD116B", Description = "Minikit Detector" },
                new CheatCode { Code = "RP924W", Description = "Moustaches" },
                new CheatCode { Code = "92UJ7D", Description = "Padme" },
                new CheatCode { Code = "R840JU", Description = "PK Droid" },
                new CheatCode { Code = "BEQ82H", Description = "Princess Leia" },
                new CheatCode { Code = "YD77GC", Description = "Purple" },
                new CheatCode { Code = "L54YUK", Description = "Rebel Trooper" },
                new CheatCode { Code = "PP43JX", Description = "Royal Guard" },
                new CheatCode { Code = "EUW862", Description = "Shaak Ti" },
                new CheatCode { Code = "MS999Q", Description = "Silhouettes" },
                new CheatCode { Code = "NR37W1", Description = "Silly Blasters" },
                new CheatCode { Code = "XZNR21", Description = "Super Battle Droid" },
                new CheatCode { Code = "PUCEAT", Description = "Tea Cups" },
            };
    }
}
