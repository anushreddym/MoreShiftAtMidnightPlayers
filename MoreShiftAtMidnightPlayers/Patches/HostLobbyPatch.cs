using HarmonyLib;
namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(PlatformManager_Steam), "HostLobby")]
    internal class HostLobbyPatch
    {
        public static void Postfix()
        {
            PlatformManager.s_MAXPLAYERS = Plugin.SelectedMaxPlayers;
            Plugin.MyLog.LogInfo($"Set PlatformManager.s_MAXPLAYERS = {Plugin.SelectedMaxPlayers}");
        }
    }
}