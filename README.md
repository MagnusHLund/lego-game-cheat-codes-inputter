# lego-game-cheat-codes-inputter

Inputs cheat codes for all lego games.

This is specifically built for the PC versions of the lego games.

---

When starting the program, ensure that you are already on the cheat code screen and all the inputs are "A" (default position), before selecting your game.

## Input speed

Adjust the delays in `LegoGamesCheatCodeInputter/appsettings.json`. Lower millisecond values enter codes faster; increase them if the game misses key presses. Delay values can be set from `0` to `60000` milliseconds (60 seconds).

- `KeyEventDelayMilliseconds`: pause after each arrow or submit key.
- `CharacterSelectionDelayMilliseconds`: pause after selecting a character and before advancing to the next position.
- `CodeSubmitDelayMilliseconds`: pause after submitting each code.
- `FocusCountdownSeconds`: time to focus the game before input starts (0–60 seconds).

## Run tests

Run the automated tests with:

```sh
dotnet test LegoGamesCheatCodeInputter.Tests/LegoGamesCheatCodeInputter.Tests.csproj
```
