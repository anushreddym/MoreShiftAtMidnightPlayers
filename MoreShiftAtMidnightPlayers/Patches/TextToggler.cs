using UnityEngine;
using UnityEngine.UI;
using Il2CppInterop.Runtime.Injection;

namespace MoreShiftAtMidnightPlayers.Patches
{
    public class TextToggler : MonoBehaviour
    {
        public GameObject targetText;

        public TextToggler(System.IntPtr ptr) : base(ptr) { }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Backslash))
            {
                Plugin.MyLog.LogInfo("Backslash pressed!");
                if (targetText != null)
                {
                    targetText.SetActive(!targetText.activeSelf);
                    Plugin.MyLog.LogInfo($"Text visibility toggled: {targetText.activeSelf}");
                }
                else
                {
                    Plugin.MyLog.LogWarning("targetText is null!");
                }
            }
        }
    }
}