using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoPiratesOfTheCaribbeanTheVideoGame : AbstractGame
    {
        public override string Title { get; } = "Lego Pirates of the Caribbean: The Video Game";

        public override IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "EW8T6T", Description = "Ammand the Corsair" },
                new CheatCode { Code = "DLRR45", Description = "Angelica (disguised)" },
                new CheatCode { Code = "VGF32C", Description = "Angry Cannibal" },
                new CheatCode { Code = "D3DW0D", Description = "Blackbeard" },
                new CheatCode { Code = "ZM37GT", Description = "Clanker" },
                new CheatCode { Code = "644THF", Description = "Clubba" },
                new CheatCode { Code = "4DJLKR", Description = "Davy Jones" },
                new CheatCode { Code = "LD9454", Description = "Governor Weatherby Swann" },
                new CheatCode { Code = "Y611WB", Description = "Gunner" },
                new CheatCode { Code = "64BNHG", Description = "Hungry Cannibal" },
                new CheatCode { Code = "VDJSPW", Description = "Jack Sparrow" },
                new CheatCode { Code = "BWO656", Description = "Jacoby" },
                new CheatCode { Code = "13GLW5", Description = "Jimmy Legs" },
                new CheatCode { Code = "RKED43", Description = "King George" },
                new CheatCode { Code = "RT093G", Description = "Koehler" },
                new CheatCode { Code = "GDETDE", Description = "Mistress Ching" },
                new CheatCode { Code = "WEV040", Description = "Phillip" },
                new CheatCode { Code = "RX58HU", Description = "Quartermaster" },
                new CheatCode { Code = "P861JO", Description = "The Spaniard" },
                new CheatCode { Code = "KDLFKD", Description = "Twigg" },
            };
    }
}
