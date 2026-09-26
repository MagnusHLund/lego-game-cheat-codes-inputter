using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoWorlds : IGame
    {
        public string Title { get; } = "Lego Worlds";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "XP3BN2", Description = "Lance's Twin Jouster" },
                new CheatCode { Code = "LY9C8M", Description = "Ruina's Lock & Roller" },
                new CheatCode { Code = "P42FJ6", Description = "Police Car" },
                new CheatCode { Code = "BG7DWK", Description = "Getaway Car" },
                new CheatCode { Code = "U98BR2", Description = "Pizza Van" },
                new CheatCode { Code = "ND284C", Description = "Jungle Buggy" },
                new CheatCode { Code = "XP76VF", Description = "Jungle Cargo Helicopter" },
                new CheatCode { Code = "YG43JH", Description = "Manta Ray Bomber" },
                new CheatCode { Code = "PPA72V", Description = "Tuk-Tuk Vehicle" },
                new CheatCode { Code = "X29VTY", Description = "Monster Scientist" },
                new CheatCode { Code = "8B3VEQ", Description = "Pink Convertible" },
                new CheatCode { Code = "VN4MHZ", Description = "Barbarian" },
                new CheatCode { Code = "NA3ZKE", Description = "Toy Soldier" },
                new CheatCode { Code = "TJPZLV", Description = "New Year Dog" },
                new CheatCode { Code = "BR1CK5", Description = "Unlock All Bricks" },
                new CheatCode { Code = "F1XTRS", Description = "Unlock All Windows & Doors" },
                new CheatCode { Code = "SKELE+", Description = "Skeletons carry dynamite" },
                new CheatCode { Code = "DRUMST", Description = "Chickens thrown into lava drop drumsticks" },
                new CheatCode { Code = "CROISS", Description = "Throwing croissants spawns the Old Cafe" },
            };
    }
}
