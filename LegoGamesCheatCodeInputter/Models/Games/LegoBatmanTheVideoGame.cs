using LegoGamesCheatCodeInputter.Controllers.Interfaces;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoBatmanTheVideoGame : AbstractGame
    {
        public override string Title { get; } = "Lego Batman: The Video Game";

        public override InputKey[] DefaultSubmitInputs { get; } = { InputKey.U, InputKey.NumPad5 };

        public override InputOptimizations InputOptimizations { get; } = new InputOptimizations { CanResetByGoingRight = false };

        public override IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "TL3EKT", Description = "Area Effect (Sonic Suit)" },
                new CheatCode { Code = "N8JZEK", Description = "Armour Plating (Demolition Suit)" },
                new CheatCode { Code = "ZQW637", Description = "Alfred" },
                new CheatCode { Code = "KNTT4B", Description = "Bat Tank" },
                new CheatCode { Code = "JKR331", Description = "Batgirl" },
                new CheatCode { Code = "XFP4E2", Description = "Bats (Sonic Suit)" },
                new CheatCode { Code = "BDJ327", Description = "Bruce Wayne" },
                new CheatCode { Code = "LEA664", Description = "Bruce Wayne's Jet" },
                new CheatCode { Code = "M1AAWW", Description = "Catwoman (Classic)" },
                new CheatCode { Code = "HPL826", Description = "Catwoman's Motorcycle" },
                new CheatCode { Code = "DDP967", Description = "Commissioner Gordon" },
                new CheatCode { Code = "TQ09K3", Description = "Decoy" },
                new CheatCode { Code = "RM4PR8", Description = "Fast Grapple (All Suits)" },
                new CheatCode { Code = "JRBDCB", Description = "Faster Batarangs" },
                new CheatCode { Code = "EVG26J", Description = "Faster Pieces" },
                new CheatCode { Code = "ZOLM6N", Description = "Fast Walk" },
                new CheatCode { Code = "D8NYWH", Description = "Flaming Batarangs" },
                new CheatCode { Code = "XPN4NG", Description = "Frozen Batarangs" },
                new CheatCode { Code = "DUS483", Description = "Garbage Truck" },
                new CheatCode { Code = "HJH7HJ", Description = "Heart Regeneration" },
                new CheatCode { Code = "18HW07", Description = "Increase Score x 10" },
                new CheatCode { Code = "JXUDY6", Description = "Immunity to Freeze" },
                new CheatCode { Code = "WYD5CP", Description = "Invincibility" },
                new CheatCode { Code = "UTF782", Description = "The Joker's Henchman" },
                new CheatCode { Code = "JUK657", Description = "The Joker's Van" },
                new CheatCode { Code = "CCB199", Description = "The Joker (Tropical)" },
                new CheatCode { Code = "M4DM4N", Description = "Mad Hatter's Boat" },
                new CheatCode { Code = "HS000W", Description = "Mad Hatter's Glider" },
                new CheatCode { Code = "ZXGH9J", Description = "Minikit Detector" },
                new CheatCode { Code = "XWP645", Description = "More Batarang Targets (All Suits)" },
                new CheatCode { Code = "TNTN6B", Description = "More Detonators (Demolition Suit)" },
                new CheatCode { Code = "ML3KHP", Description = "Add More Hearts" },
                new CheatCode { Code = "9LRGNB", Description = "Multiply Score" },
                new CheatCode { Code = "MVY759", Description = "Nightwing" },
                new CheatCode { Code = "KHJ544", Description = "Piece Detector" },
                new CheatCode { Code = "MMN786", Description = "Power Brick Detector" },
                new CheatCode { Code = "LJP234", Description = "Police Bike" },
                new CheatCode { Code = "PLC999", Description = "Police Boat" },
                new CheatCode { Code = "CWR732", Description = "Police Helicopter" },
                new CheatCode { Code = "HKG984", Description = "Police Sniper" },
                new CheatCode { Code = "MAC788", Description = "Police Van" },
                new CheatCode { Code = "JRY983", Description = "Police Officer" },
                new CheatCode { Code = "N4NR3E", Description = "Score Multiplier x2" },
                new CheatCode { Code = "CX9MAT", Description = "Score Multiplier x4" },
                new CheatCode { Code = "MLVNF2", Description = "Score Multiplier x6" },
                new CheatCode { Code = "WCCDB9", Description = "Score Multiplier x8" },
                new CheatCode { Code = "JFL786", Description = "Scientist" },
                new CheatCode { Code = "PLB946", Description = "Security Guard" },
                new CheatCode { Code = "BBD7BY", Description = "Slam (Glide Suit)" },
                new CheatCode { Code = "THTL4X", Description = "Sonic Pain (Sonic Suit)" },
                new CheatCode { Code = "MKL382", Description = "Soldier" },
                new CheatCode { Code = "LK2DY4", Description = "Stud Magnet" },
                new CheatCode { Code = "HTF114", Description = "SWAT Officer" },
                new CheatCode { Code = "TTF453", Description = "Robin's Sub" },
                new CheatCode { Code = "NAV592", Description = "Sailor" },
                new CheatCode { Code = "XEU824", Description = "Riddler's Henchman" },
                new CheatCode { Code = "HAHAHA", Description = "Riddler's Plane" },
                new CheatCode { Code = "XVK541", Description = "Mr. Freeze's Girl" },
                new CheatCode { Code = "BCT229", Description = "Mr. Freeze's Car" },
                new CheatCode { Code = "GTB899", Description = "Poison Ivy Henchman" },
                new CheatCode { Code = "DWR243", Description = "Zoo Sweeper" },
                new CheatCode { Code = "EFE933", Description = "Two-Face's Truck" },
                new CheatCode { Code = "NJL412", Description = "Yeti" },
            };
    }
}
