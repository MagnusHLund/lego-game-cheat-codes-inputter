using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models.Games
{
    public sealed class LegoCityUndercover : IGame
    {
        public string Title { get; } = "Lego City Undercover";

        public IReadOnlyList<CheatCode> Codes { get; } =
            new List<CheatCode>
            {
                new CheatCode { Code = "ACJDUN", Description = "Studs x2" },
                new CheatCode { Code = "AZ9JMW", Description = "Studs x4" },
                new CheatCode { Code = "HNC9MC", Description = "Studs x6" },
                new CheatCode { Code = "QRXQ4A", Description = "Studs x8" },
                new CheatCode { Code = "3NMUQM", Description = "Studs x10" },
                new CheatCode { Code = "QPYAHP", Description = "Super ram" },
                new CheatCode { Code = "46YLWF", Description = "Fast build" },
                new CheatCode { Code = "LX9LMN", Description = "Super throw" },
                new CheatCode { Code = "Y8VQWW", Description = "Fall rescue" },
                new CheatCode { Code = "EWYX68", Description = "Extra hearts" },
                new CheatCode { Code = "PRKH98", Description = "Invicibility" },
                new CheatCode { Code = "DDBAPC", Description = "Super ray gun" },
                new CheatCode { Code = "WBKU9C", Description = "Attract studs" },
                new CheatCode { Code = "9BUK3T", Description = "Attract bricks" },
                new CheatCode { Code = "7GVTDW", Description = "Wonder whistle" },
                new CheatCode { Code = "ELUVW9", Description = "Ringtone - fart" },
                new CheatCode { Code = "EU6R97", Description = "Nitrous for all" },
                new CheatCode { Code = "M7AL7Y", Description = "Super axe smash" },
                new CheatCode { Code = "XGCQG8", Description = "Super color gun" },
                new CheatCode { Code = "3ET876", Description = "Super drill ride" },
                new CheatCode { Code = "66KB9W", Description = "Super safe crack" },
                new CheatCode { Code = "ANMUJ8", Description = "Police siren hat" },
                new CheatCode { Code = "EC9WLW", Description = "Super fast travel" },
                new CheatCode { Code = "MGH7C3", Description = "Super astro crate" },
                new CheatCode { Code = "JCJFHV", Description = "Unlimited dynamite" },
                new CheatCode { Code = "NAGXGC", Description = "Super break & enter" },
                new CheatCode { Code = "9ELGA9", Description = "Longer vehicle boost" },
                new CheatCode { Code = "3VMFBJ", Description = "Collect sat nav studs" },
                new CheatCode { Code = "VGU7X4", Description = "Data scan upgrade - tokens" },
                new CheatCode { Code = "9WDTTJ", Description = "Data scan upgrade - red bricks" },
                new CheatCode { Code = "C6M7AJ", Description = "Data scan upgrade - city challenges" },
                new CheatCode { Code = "V3YTDC", Description = "Data scan upgrade - points of interest" },
                new CheatCode { Code = "LB978Y", Description = "Data scan upgrade - character challenges" },
            };
    }
}
