using SharpHook;
using SharpHook.Data;
using SharpHook.Simulation;

namespace LegoGamesCheatCodeInputter.Controllers
{
    /// <summary>Cross-platform keyboard sender backed by SharpHook/libuiohook.</summary>
    public sealed class SharpHookKeyboardInput : IKeyboardInput
    {
        private readonly IEventSimulator _simulator = EventSimulator.Create(
            "LEGO Games Cheat Code Inputter"
        );

        public void Press(InputKey key)
        {
            KeyCode nativeKey = key switch
            {
                InputKey.Up => KeyCode.VcUp,
                InputKey.Down => KeyCode.VcDown,
                InputKey.Right => KeyCode.VcRight,
                InputKey.Enter => KeyCode.VcEnter,
                _ => throw new ArgumentOutOfRangeException(nameof(key), key, null),
            };

            UioHookResult result = _simulator.SimulateKeyStroke(nativeKey);
            if (result != UioHookResult.Success)
                throw new HookException(result, $"Could not simulate the {key} key.");
        }

        public void Dispose() => _simulator.Dispose();
    }
}
