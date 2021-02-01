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

    [HarmonyPatch(typeof(vp_FPSCamera), "Start")]
    internal static class vp_FPSCamera_Start
    {
        internal static void Postfix(vp_FPSCamera __instance)
        {
            __instance.m_MaxAmbientSwayAngleDegreesA = 0;
        }
    }
}
