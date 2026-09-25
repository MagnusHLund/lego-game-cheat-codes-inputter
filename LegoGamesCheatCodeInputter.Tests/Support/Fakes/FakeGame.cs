using LegoGamesCheatCodeInputter.Models;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Tests.Support.Fakes;

internal sealed record FakeGame(string Title, IReadOnlyList<CheatCode> Codes) : IGame;
