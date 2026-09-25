using LegoGamesCheatCodeInputter.Models;

namespace LegoGamesCheatCodeInputter.Tests.Models;

public sealed class GameRegistryTests
{
    [Fact]
    public void RegisteredGames_HaveUniqueNonBlankTitlesAndValidCodeEntries()
    {
        Assert.NotEmpty(GameRegistry.Games);
        Assert.All(GameRegistry.Games, game =>
        {
            Assert.False(string.IsNullOrWhiteSpace(game.Title));
            Assert.NotNull(game.Codes);
            Assert.All(game.Codes, code =>
            {
                Assert.False(string.IsNullOrWhiteSpace(code.Code));
                Assert.False(string.IsNullOrWhiteSpace(code.Description));
                Assert.Matches("^[A-Z0-9]+$", code.Code);
            });
        });

        Assert.Equal(
            GameRegistry.Games.Count,
            GameRegistry.Games.Select(game => game.Title).Distinct(StringComparer.OrdinalIgnoreCase).Count()
        );
    }
}
