using Harmony;

namespace DisableCameraSway
{
    [HarmonyPatch(typeof(PlayerManager), "MaybeRotateCamera")]
    internal static class PlayerManager_MaybeRotateCamera
    {
        internal static bool Prefix()
        {
            return false;
        }
    }
}
