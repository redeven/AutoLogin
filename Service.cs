using Dalamud.Data;
using Dalamud.Game;
using Dalamud.Game.ClientState.Conditions;
using Dalamud.Game.Command;
using Dalamud.Game.Gui;
using Dalamud.Interface;
using Dalamud.IoC;
using Dalamud.Plugin;
using System.Diagnostics.CodeAnalysis;
using Dalamud.Game.ClientState.Keys;
using Dalamud.Game.ClientState;

#pragma warning disable CA1416 // Validate platform compatibility
namespace AutoLogin {
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    public class Service {
        [PluginService] public static DalamudPluginInterface PluginInterface { get; private set; }
        [PluginService] public static CommandManager Commands { get; private set; }
        [PluginService] public static Condition Condition { get; private set; }
        [PluginService] public static DataManager Data { get; private set; }
        [PluginService] public static Framework Framework { get; private set; }
        [PluginService] public static GameGui GameGui { get; private set; }
        [PluginService] public static SigScanner SigScanner { get; private set; }
        [PluginService] public static KeyState KeyState { get; private set; }
        [PluginService] public static ClientState ClientState { get; private set; }
        [PluginService] public static ChatGui Chat { get; private set; }

        // Fake Services
        public static UiBuilder UiBuilder => PluginInterface?.UiBuilder;
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
