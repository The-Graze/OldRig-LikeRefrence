using BepInEx;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using System;
using System.Collections.Generic;
using UnityEngine;
using Utilla;

namespace OldRig_LikeRefrence
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Start()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }
    }

    public class OldRef : MonoBehaviour
    {
        public PhotonView view;
        public PhotonVoiceView voiceView;
        public VRRig Rig;
    }
}
