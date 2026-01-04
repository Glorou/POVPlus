using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;
using GameSkeleton = FFXIVClientStructs.FFXIV.Client.Graphics.Render.Skeleton;


namespace POVPlus
{
    public class Service
    {
        ///
        [PluginService] public static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
        [PluginService] public static ITextureProvider TextureProvider { get; private set; } = null!;
        [PluginService] public static ICommandManager CommandManager { get; private set; } = null!;
        [PluginService] public static IClientState ClientState { get; private set; } = null!;
        [PluginService] public static IDataManager DataManager { get; private set; } = null!;
        [PluginService] public static IPluginLog Log { get; private set; } = null!;
        [PluginService] public static IGameInteropProvider GameInteropProvider { get; private set; } = null!;
        [PluginService] public static IFramework Framework { get; private set; } = null!;

        public unsafe GameSkeleton* GameSkeleton { get; init; }


        ///Hooks

    }
}
