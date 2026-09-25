namespace LegoGamesCheatCodeInputter.Models
{
    public sealed record CheatCode
    {
        public required string Code { get; init; }
        public required string Description { get; init; }
    }
}
