using LegoGamesCheatCodeInputter.Views.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed class RecordingErrorView : IErrorView
{
    public List<Exception> Exceptions { get; } = new();

    public void Render(Exception exception) => Exceptions.Add(exception);
}
