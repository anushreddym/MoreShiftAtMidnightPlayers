using System;
using HarmonyLib;
using TMPro;


namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(CreateLobbySettings), "UpdateDropdownLanguage")]
    internal class ExtendDropdownPatch
    {
        public static void Postfix(CreateLobbySettings __instance)
        {
            try
            {
                TMP_Dropdown dropdown = __instance.maxPlayersDropdown;
                if (dropdown == null || dropdown.options == null) return;
                int desiredMax = Plugin.MaxPlayers.Value;

                while (dropdown.options.Count < desiredMax)
                {
                    int nextValue = dropdown.options.Count + 1;
                    dropdown.options.Add(new TMP_Dropdown.OptionData(nextValue.ToString()));
                }
                dropdown.RefreshShownValue();

                Plugin.MyLog.LogInfo($"Dropdown extended to {desiredMax} options");
            }
            catch (Exception ex)
            {
                Plugin.MyLog.LogError($"Failed to extend dropdown: {ex.Message}");
            }
        }
    }
}
