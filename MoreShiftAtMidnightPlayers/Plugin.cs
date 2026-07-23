using BepInEx;
using BepInEx.Unity.IL2CPP;
using BepInEx.Logging;
using BepInEx.Configuration;
using HarmonyLib;
using Il2CppInterop.Runtime.Injection;
namespace MoreShiftAtMidnightPlayers
{
    [BepInPlugin("com.curiosity.moreshiftatmidnightplayers", "MoreShiftAtMidnightPlayers", "1.0.0")]
    internal class Plugin : BasePlugin
    {
        internal static ManualLogSource MyLog;
        internal static ConfigEntry<int> MaxPlayers;
        internal static int SelectedMaxPlayers = 3; // fallback

        public override void Load()
        {
            MyLog = base.Log;
            MyLog.LogInfo("MoreShiftAtMidnightPlayers is loading...");

            MaxPlayers = Config.Bind(
                "General",
                "MaxPlayers",
                8,
                new ConfigDescription(
                    "Max players per session",
                    new AcceptableValueRange<int>(2, 32)
                )
            );

            ClassInjector.RegisterTypeInIl2Cpp<Patches.TextToggler>();
            var harmony = new Harmony("com.curiosity.moreshiftatmidnightplayers");
            harmony.PatchAll();
            MyLog.LogInfo("Patches applied.");
        }
    }
}