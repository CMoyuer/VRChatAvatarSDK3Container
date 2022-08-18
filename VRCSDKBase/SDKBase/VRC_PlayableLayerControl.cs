using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_PlayableLayerControl : StateMachineBehaviour
    {
        [HideInInspector]
        public static InitializationDelegate Initialize;
        [Tooltip("Layer to affect")]
        public BlendableLayer layer;
        [Range(0, 1)]
        [Tooltip("Goal weight 0-1")]
        public float goalWeight;
        [Tooltip("Time to reach goal weight")]
        public float blendDuration;
        [Tooltip("Message for debugging")]
        public string debugString;
        [HideInInspector]
        public ApplySettingsDelegate ApplySettings;
        [HideInInspector]
        public int outputParamHash;

        protected VRC_PlayableLayerControl() { }

        [System.Serializable]
        public enum BlendableLayer
        {
            Action = 0,
            FX = 1,
            Gesture = 2,
            Additive = 3
        }

        [HideInInspector]
        public delegate void InitializationDelegate(VRC_PlayableLayerControl obj);
        [HideInInspector]
        public delegate void ApplySettingsDelegate(VRC_PlayableLayerControl control, Animator animator);
    }
}
