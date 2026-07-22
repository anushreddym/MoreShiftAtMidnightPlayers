using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;

namespace MoreShiftAtMidnightPlayers
{
    [BepInPlugin("com.curiosity.moreshiftatmidnightplayers", "MoreShiftAtMidnightPlayers", "1.0.0")]
    internal class Plugin : BasePlugin
    {
        internal static ManualLogSource MyLog;
        internal static int SelectedMaxPlayers = 3; // fallback

        public override void Load()
        {
            MyLog = base.Log;
            MyLog.LogInfo("MoreShiftAtMidnightPlayers is loading...");

            ClassInjector.RegisterTypeInIl2Cpp<Patches.TextToggler>();

            var harmony = new Harmony("com.curiosity.moreshiftatmidnightplayers");
            harmony.PatchAll();
            MyLog.LogInfo("Patches applied.");
        }
    }
}