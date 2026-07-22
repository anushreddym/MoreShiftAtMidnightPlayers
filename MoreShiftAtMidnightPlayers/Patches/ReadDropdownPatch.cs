using System;
using HarmonyLib;

namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(CreateLobbySettings), "StartLobby")]
    public static class ReadDropdownPatch
    {
        public static void Prefix(CreateLobbySettings __instance)
        {
            try
            {
                int chosenValue = __instance.maxPlayersDropdown.value + 1; 
                Plugin.SelectedMaxPlayers = Math.Clamp(chosenValue, 1, 8);

                Plugin.MyLog.LogInfo($"Host selected max players = {Plugin.SelectedMaxPlayers}");
            }
            catch (Exception ex)
            {
                Plugin.MyLog.LogError($"Failed to read dropdown selection: {ex.Message}");
            }
        }
    }
}