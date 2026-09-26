using LegoGamesCheatCodeInputter.Models.Games;
using LegoGamesCheatCodeInputter.Models.Games.Interfaces;

namespace LegoGamesCheatCodeInputter.Models
{
    public static class GameRegistry
    {
        //! Commented out games are unsupported, as of now, due to their different cheat code input system.

        public static IReadOnlyList<IGame> Games { get; } =
            new List<IGame>
            {
                new LegoBatmanTheVideoGame(),
                new LegoBatmanTwoDcSuperHeroes(),
                new LegoBatmanThreeBeyondGotham(),
                // new LegoCityUndercover(),
                // new LegoDcSuperVillains(),
                new LegoHarryPotterYears1To4(),
                new LegoHarryPotterYears5To7(),
                new LegoIndianaJonesTheOriginalAdventures(),
                new LegoIndianaJonesTwoTheAdventureContinues(),
                new LegoJurassicWorld(),
                new LegoLordOfTheRings(),
                new LegoMarvelAvengers(),
                new LegoMarvelSuperHeroes(),
                new LegoMarvelSuperHeroesTwo(),
                new LegoPiratesOfTheCaribbeanTheVideoGame(),
                new LegoStarWarsTheCompleteSaga(),
                new LegoStarWarsTheForceAwakens(),
                // new LegoStarWarsTheSkywalkerSaga(),
                new LegoStarWarsTheVideoGame(),
                new LegoStarWarsThreeTheCloneWars(),
                new LegoStarWarsTwoTheOriginalTrilogy(),
                new LegoTheHobbit(),
                // new LegoTheIncredibles(),
                // new LegoWorlds(),
                // new TheLegoMovieTwoVideoGame(),
                // new TheLegoMovieVideoGame(),
                new TheLegoNinjagoMovieVideoGame(),
            };
    }
}
