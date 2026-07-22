using HarmonyLib;
using Steamworks;

namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(SteamMatchmaking), "CreateLobby")]
    internal class SteamLobbyPatch
    {
        public static void Prefix(ref int cMaxMembers)
        {
            cMaxMembers = Plugin.SelectedMaxPlayers;
            Plugin.MyLog.LogInfo($"Overrode lobby size to {Plugin.SelectedMaxPlayers}");
        }
    }
}
