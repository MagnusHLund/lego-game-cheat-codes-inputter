namespace LegoGamesCheatCodeInputter.Configuration
{
    public sealed record InputSettingsOptions
    {
        public int KeyHoldDurationMilliseconds { get; init; } = 60;
        public int KeyEventDelayMilliseconds { get; init; } = 60;
        public int CharacterSelectionDelayMilliseconds { get; init; } = 120;
        public int CodeSubmitDelayMilliseconds { get; init; } = 120;
    }
}
