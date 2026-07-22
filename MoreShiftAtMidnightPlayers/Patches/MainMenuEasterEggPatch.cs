using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace MoreShiftAtMidnightPlayers.Patches
{
    [HarmonyPatch(typeof(MainMenu), "Start")]
    public static class MainMenuEasterEggPatch
    {
        public static void Postfix(MainMenu __instance)
        {
            try
            {
                GameObject textObj = new GameObject("Text");
                Canvas canvas = UnityEngine.Object.FindObjectOfType<Canvas>();
                if (canvas == null)
                {
                    Plugin.MyLog.LogWarning("No canvas found to attach text to.");
                    return;
                }
                textObj.transform.SetParent(canvas.transform, false);
                TextMeshProUGUI tmp = textObj.AddComponent<TextMeshProUGUI>();
                tmp.text = "ichiban kasuga";
                tmp.fontSize = 22;
                tmp.color = Color.yellow;
                tmp.alignment = TextAlignmentOptions.TopRight;
                RectTransform rect = textObj.GetComponent<RectTransform>();
                rect.anchorMin = new Vector2(1, 1);
                rect.anchorMax = new Vector2(1, 1);
                rect.pivot = new Vector2(1, 1);
                rect.anchoredPosition = new Vector2(-20, -100);
                rect.sizeDelta = new Vector2(300, 50);
                textObj.SetActive(false);

                var toggler = canvas.gameObject.AddComponent<TextToggler>();
                toggler.targetText = textObj;

                Plugin.MyLog.LogInfo("Text added to main menu.");
            }
            catch (System.Exception ex)
            {
                Plugin.MyLog.LogError($"Failed to add text: {ex.Message}");
            }
        }
    }
}