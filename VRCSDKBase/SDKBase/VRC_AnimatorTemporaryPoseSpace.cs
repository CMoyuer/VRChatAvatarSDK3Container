using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_AnimatorTemporaryPoseSpace : StateMachineBehaviour
    {
        [HideInInspector]
        public static InitializationDelegate Initialize;
        [Tooltip("Enter or exit a pose space based on the avatar's current pose.")]
        public bool enterPoseSpace;
        [Tooltip("Is the delay fixed or normalized.")]
        public bool fixedDelay;
        [Tooltip("Delay before applying.")]
        public float delayTime;
        [Tooltip("Message for debugging")]
        public string debugString;
        [HideInInspector]
        public ApplySettingsDelegate ApplySettings;

        protected VRC_AnimatorTemporaryPoseSpace() { }

        [HideInInspector]
        public delegate void InitializationDelegate(VRC_AnimatorTemporaryPoseSpace obj);
        [HideInInspector]
        public delegate void ApplySettingsDelegate(VRC_AnimatorTemporaryPoseSpace view, Animator animator);
    }
}
