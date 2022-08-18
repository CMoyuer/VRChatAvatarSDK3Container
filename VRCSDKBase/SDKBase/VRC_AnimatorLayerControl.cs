using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_AnimatorLayerControl : StateMachineBehaviour
    {
        [HideInInspector]
        public static InitializationDelegate Initialize;
        [Tooltip("Playable layer to affect")]
        public BlendableLayer playable;
        [Tooltip("Index of sub-layer to affect")]
        public int layer;
        [Range(0, 1)]
        [Tooltip("Goal weight 0-1")]
        public float goalWeight;
        [Tooltip("Time to reach goal weight, should be less than animation length")]
        public float blendDuration;
        [Tooltip("Message for debugging")]
        public string debugString;
        [HideInInspector]
        public ApplySettingsDelegate ApplySettings;

        protected VRC_AnimatorLayerControl() { }
        [System.Serializable]
        public enum BlendableLayer
        {
            Action = 0,
            FX = 1,
            Gesture = 2,
            Additive = 3
        }

        [HideInInspector]
        public delegate void InitializationDelegate(VRC_AnimatorLayerControl obj);
        [HideInInspector]
        public delegate void ApplySettingsDelegate(VRC_AnimatorLayerControl control, Animator animator);
    }
}
