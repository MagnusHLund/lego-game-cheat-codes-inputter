using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class TheLegoMovieVideoGame : IGame
    {
        public string Title { get; } = "The Lego Movie Video Game";

        public IReadOnlyList<CheatCode> Codes { get; } = new List<CheatCode>
        {
            new CheatCode { Code = "F3VG47", Description = "Abraham Lincolin" },
            new CheatCode { Code = "6LK78NN9", Description = "Angry Kitty & Construction Pants" },
            new CheatCode { Code = "HVLH63VL", Description = "Angry Kitty & Construction Pants" },
            new CheatCode { Code = "6LKMNDHR", Description = "Blacktron Fan & Musical Pants" },
            new CheatCode { Code = "HVLLRX6R", Description = "Blacktron Fan & Musical Pants" },
            new CheatCode { Code = "P4YX22", Description = "Cleopatra" },
            new CheatCode { Code = "FNHLTK", Description = "Emmet (Clown)" },
            new CheatCode { Code = "UOOAQY", Description = "Emmet (Lizard)" },
            new CheatCode { Code = "NIHX2B", Description = "Emmet (Old West)" },
            new CheatCode { Code = "HJ4C21", Description = "Emmet (Pajamas)" },
            new CheatCode { Code = "FXP9AN", Description = "Gallant Guard" },
            new CheatCode { Code = "OSSVNI", Description = "Green Ninja" },
            new CheatCode { Code = "6LK3FRL6", Description = "Johnny Thunder & Super Secret Pants" },
            new CheatCode { Code = "HVL4TQT4", Description = "Johnny Thunder & Super Secret Pants" },
            new CheatCode { Code = "A76DN7", Description = "Lady Liberty" },
            new CheatCode { Code = "K7TDXJ", Description = "Larry The Barista" },
            new CheatCode { Code = "KGJ4DU", Description = "Lord Vampyre" },
            new CheatCode { Code = "UP7HJQ", Description = "Mrs. Scratchen-Post" },
            new CheatCode { Code = "NG73OM", Description = "Panda Guy" },
            new CheatCode { Code = "FHNCD1", Description = "Prospector" },
            new CheatCode { Code = "6LK3RRY4", Description = "Robo Pilot & Astro Pants" },
            new CheatCode { Code = "HVL4TB94", Description = "Robo Pilot & Astro Pants" },
            new CheatCode { Code = "GFH2F8", Description = "Robo SWAT (Laser)" },
            new CheatCode { Code = "31S3I5", Description = "Shakespeare" },
            new CheatCode { Code = "BID12F", Description = "Swamp Creature" },
            new CheatCode { Code = "BC2XJ5", Description = "Vitruvious (Young)" },
            new CheatCode { Code = "V4P96P", Description = "Yeti" },
        };
    }
}
