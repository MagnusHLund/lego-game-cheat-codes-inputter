using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoBatmanTheVideoGame : IGame
    {
        public string Title { get; } = "Lego Batman: The Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "WYD5CP", Description = "Invincibility" },
                new CheatCode { Code = "ZAQ637", Description = "Unlocks Alfred" },
                new CheatCode { Code = "NAV592", Description = "Unlocks Sailor" },
                new CheatCode { Code = "JKR331", Description = "Unlocks Batgirl" },
                new CheatCode { Code = "NYU942", Description = "Unlocks Man-Bat" },
                new CheatCode { Code = "ML3KHP", Description = "Add More Hearts" },
                new CheatCode { Code = "HTF114", Description = "Unlocks S.W.A.T." },
                new CheatCode { Code = "JFL786", Description = "Unlocks Scientist" },
                new CheatCode { Code = "JCA283", Description = "Unlocks Mad Hatter" },
                new CheatCode { Code = "HJK327", Description = "Unlocks Clown Goon" },
                new CheatCode { Code = "HGY748", Description = "Unlocks Fishmonger" },
                new CheatCode { Code = "UTF782", Description = "Unlocks Joker Goon" },
                new CheatCode { Code = "XVK541", Description = "Unlocks Freeze Girl" },
                new CheatCode { Code = "18HW07", Description = "Increase Score x 10" },
                new CheatCode { Code = "DWR243", Description = "Unlocks Zoo Sweeper" },
                new CheatCode { Code = "CRY928", Description = "Unlocks Riddler Goon" },
                new CheatCode { Code = "NKA238", Description = "Unlocks Penguin Goon" },
                new CheatCode { Code = "YUN924", Description = "Unlocks Joker Henchman" },
                new CheatCode { Code = "JRY983", Description = "Unlocks Police Officer" },
                new CheatCode { Code = "PLB946", Description = "Unlocks Security Guard" },
                new CheatCode { Code = "GTB899", Description = "Unlocks Poison Ivy Goon" },
                new CheatCode { Code = "HKG984", Description = "Unlocks Police Marksman" },
                new CheatCode { Code = "XEU824", Description = "Unlocks Riddler Henchman" },
                new CheatCode { Code = "BJH782", Description = "Unlocks Penguin Henchman" },
                new CheatCode { Code = "MKL382", Description = "Unlocks Military Policeman" },
                new CheatCode { Code = "M1AAWW", Description = "Unlocks Catwoman (Classic)" },
            };
    }
}
