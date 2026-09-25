using LegoGamesCheatCodeInputter.Configuration;
using LegoGamesCheatCodeInputter.Tests.Support.Fakes;

namespace LegoGamesCheatCodeInputter.Tests.Configuration;

public sealed class SettingsTests
{
    [Fact]
    public void MissingFile_ReturnsDefaultSettings()
    {
        AppSettings settings = AppSettings.Load(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".json"));

        Assert.Equal(60, settings.Input.KeyEventDelayMilliseconds);
        Assert.Equal(120, settings.Input.CharacterSelectionDelayMilliseconds);
        Assert.Equal(120, settings.Input.CodeSubmitDelayMilliseconds);
        Assert.Equal(5, settings.FocusCountdownSeconds);
    }

    [Fact]
    public void ValidFile_LoadsAllSettings()
    {
        using TemporarySettingsFile file = new("""
            { "Input": { "KeyEventDelayMilliseconds": 0, "CharacterSelectionDelayMilliseconds": 60000,
              "CodeSubmitDelayMilliseconds": 250 }, "FocusCountdownSeconds": 0 }
            """);

        AppSettings settings = AppSettings.Load(file.Path);

        Assert.Equal(0, settings.Input.KeyEventDelayMilliseconds);
        Assert.Equal(60000, settings.Input.CharacterSelectionDelayMilliseconds);
        Assert.Equal(250, settings.Input.CodeSubmitDelayMilliseconds);
        Assert.Equal(0, settings.FocusCountdownSeconds);
    }

    [Theory]
    [InlineData("{ broken")]
    [InlineData("")]
    public void MalformedOrEmptyFile_ThrowsUsefulError(string json)
    {
        using TemporarySettingsFile file = new(json);

        Assert.Throws<InvalidDataException>(() => AppSettings.Load(file.Path));
    }

    [Theory]
    [InlineData("KeyEventDelayMilliseconds", -1)]
    [InlineData("KeyEventDelayMilliseconds", 60001)]
    [InlineData("CharacterSelectionDelayMilliseconds", -1)]
    [InlineData("CharacterSelectionDelayMilliseconds", 60001)]
    [InlineData("CodeSubmitDelayMilliseconds", -1)]
    [InlineData("CodeSubmitDelayMilliseconds", 60001)]
    public void DelayOutsideRange_Throws(string setting, int value)
    {
        using TemporarySettingsFile file = new($"{{ \"Input\": {{ \"{setting}\": {value} }} }}");

        Assert.Throws<InvalidDataException>(() => AppSettings.Load(file.Path));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(61)]
    public void CountdownOutsideRange_Throws(int value)
    {
        using TemporarySettingsFile file = new($"{{ \"FocusCountdownSeconds\": {value} }}");

        Assert.Throws<InvalidDataException>(() => AppSettings.Load(file.Path));
    }

    [Fact]
    public void NullInputSection_Throws()
    {
        using TemporarySettingsFile file = new("{ \"Input\": null }");

        Assert.Throws<InvalidDataException>(() => AppSettings.Load(file.Path));
    }
}
