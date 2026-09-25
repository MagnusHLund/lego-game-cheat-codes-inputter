using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoBatmanTwoDcSuperHeroes : IGame
    {
        public string Title { get; } = "Lego Batman 2: DC Super Heroes";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "W49CSJ", Description = "Unlocks LexBot" },
                new CheatCode { Code = "ZQA8MK", Description = "Unlocks Mime Goon" },
                new CheatCode { Code = "9ZZZBP", Description = "Unlocks Clown Goon" },
                new CheatCode { Code = "Q285LK", Description = "Unlocks Riddler Goon" },
                new CheatCode { Code = "95KPYJ", Description = "Unlocks Two-Face Goon" },
                new CheatCode { Code = "V9SAGT", Description = "Unlocks Police Officer" },
                new CheatCode { Code = "74EZUT", Description = "Unlocks “Studs x 2” Red Brick" },
                new CheatCode { Code = "ZHAXFH", Description = "Unlocks “Beep Beep” Red Brick" },
                new CheatCode { Code = "BWQ2MS", Description = "Unlocks “Disguises” Red Brick" },
                new CheatCode { Code = "JN2J6V", Description = "Unlocks “Super Build” Red Brick" },
                new CheatCode { Code = "TPGPG2", Description = "Unlocks “Fall Rescue” Red Brick" },
                new CheatCode { Code = "4LGJ7T", Description = "Unlocks “Extra Hearts” Red Brick" },
                new CheatCode { Code = "7TXH5K", Description = "Unlocks “Extra Toggle” Red Brick" },
                new CheatCode { Code = "RYD3SJ", Description = "Unlocks “Peril Finder” Red Brick" },
                new CheatCode { Code = "C79LVH", Description = "Unlocks Harley Quinn's Motorbike" },
                new CheatCode { Code = "MNZER6", Description = "Unlocks “Attract Studs” Red Brick" },
                new CheatCode { Code = "JXN7FJ", Description = "Unlocks “Vine Grapples” Red Brick" },
                new CheatCode { Code = "LRJAG8", Description = "Unlocks “Minikit Finder” Red Brick" },
                new CheatCode { Code = "TPJ37T", Description = "Unlocks “Character Studs” Red Brick" },
                new CheatCode { Code = "ZXEX5D", Description = "Unlocks “Regenerate Heats” Red Brick" },
                new CheatCode { Code = "5KKQ6G", Description = "Unlocks “Red Brick Finder” Red Brick" },
                new CheatCode { Code = "MBXW7V", Description = "Unlocks “Gold Brick Finder” Red Brick" },
            };
    }
}
