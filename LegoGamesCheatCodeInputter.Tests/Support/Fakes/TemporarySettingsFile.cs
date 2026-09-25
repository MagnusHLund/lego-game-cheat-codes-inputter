namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class TemporarySettingsFile : IDisposable
{
    public string Path { get; } = System.IO.Path.Combine(
        System.IO.Path.GetTempPath(),
        $"lego-cheat-settings-{Guid.NewGuid():N}.json"
    );

    public TemporarySettingsFile(string content) => File.WriteAllText(Path, content);

    public void Dispose()
    {
        if (File.Exists(Path))
            File.Delete(Path);
    }
}
