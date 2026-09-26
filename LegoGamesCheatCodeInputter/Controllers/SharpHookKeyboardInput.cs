using LegoGamesCheatCodeInputter.Controllers.Interfaces;
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
            UioHookResult result = _simulator.SimulateKeyPress(GetNativeKey(key));
            if (result != UioHookResult.Success)
                throw new HookException(result, $"Could not simulate the {key} key.");
        }

        public void Release(InputKey key)
        {
            UioHookResult result = _simulator.SimulateKeyRelease(GetNativeKey(key));
            if (result != UioHookResult.Success)
                throw new HookException(result, $"Could not release the {key} key.");
        }

        private static KeyCode GetNativeKey(InputKey key) =>
            key switch
            {
                InputKey.Up => KeyCode.VcUp,
                InputKey.Down => KeyCode.VcDown,
                InputKey.Right => KeyCode.VcRight,
                InputKey.Left => KeyCode.VcLeft,
                InputKey.Enter => KeyCode.VcEnter,
                _ => throw new ArgumentOutOfRangeException(nameof(key), key, null),
            };

        public void Dispose() => _simulator.Dispose();
    }
}
