using MelonLoader;
using UnityEngine;

namespace DisableCameraSway
{
    internal class Implementation : MelonMod
    {
        public override void OnApplicationStart()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
        }
    }
}
