using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_AnimatorLocomotionControl : StateMachineBehaviour
    {
        [HideInInspector]
        public static InitializationDelegate Initialize;
        [Tooltip("Disable player locomotion.")]
        public bool disableLocomotion;
        [Tooltip("Message for debugging")]
        public string debugString;
        [HideInInspector]
        public ApplySettingsDelegate ApplySettings;

        protected VRC_AnimatorLocomotionControl() { }

        [HideInInspector]
        public delegate void InitializationDelegate(VRC_AnimatorLocomotionControl obj);
        [HideInInspector]
        public delegate void ApplySettingsDelegate(VRC_AnimatorLocomotionControl control, Animator animator);
    }
}
