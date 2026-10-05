namespace LegoGamesCheatCodeInputter.Configuration
{
    public sealed record InputSettingsOptions
    {
        public int KeyHoldDurationMilliseconds { get; init; } = 50;
        public int KeyEventDelayMilliseconds { get; init; } = 90;
        public int CharacterSelectionDelayMilliseconds { get; init; } = 90;
        public int CodeSubmitDelayMilliseconds { get; init; } = 50;
    }
}
