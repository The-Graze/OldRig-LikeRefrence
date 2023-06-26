using HarmonyLib;
using Photon.Pun;
using Photon.Voice.PUN;
using System;
using System.Collections.Generic;
using System.Text;

namespace OldRig_LikeRefrence.Patches
{
    [HarmonyPatch(typeof(VRRigSerializer))]
    [HarmonyPatch("OnInstantiateSetup", MethodType.Normal)]
    internal class VRRigPatch
    {
        internal static void Postfix(VRRigSerializer __instance)
        {
            __instance.vrrig.gameObject.AddComponent<OldRef>();
            __instance.vrrig.gameObject.GetComponent<OldRef>().Rig = __instance.vrrig;
            __instance.vrrig.gameObject.GetComponent<OldRef>().voiceView = __instance.GetComponent<PhotonVoiceView>();
            __instance.vrrig.gameObject.GetComponent<OldRef>().view = __instance.GetComponent<PhotonView>();
        }
    }
}
