using System;
using HarmonyLib;
using Fusion;
using Il2CppSystem;
namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(NetworkRunner), "StartGame")]
    internal class FusionStartGamePatch
    {
        public static void Prefix(StartGameArgs args)
        {
            try
            {
                args.PlayerCount = new Il2CppSystem.Nullable<int>(Plugin.SelectedMaxPlayers);
                Plugin.MyLog.LogInfo($"Set StartGameArgs.PlayerCount = {Plugin.SelectedMaxPlayers}");
            }
            catch (System.Exception ex)
            {
                Plugin.MyLog.LogError($"Failed to set PlayerCount: {ex.Message}");
            }
        }
    }
}