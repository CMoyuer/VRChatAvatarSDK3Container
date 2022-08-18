using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_AnimatorTrackingControl : StateMachineBehaviour
    {
        [HideInInspector]
        public static InitializationDelegate Initialize;
        [Tooltip("Disable tracking of user's head and follow animation instead.")]
        public TrackingType trackingHead;
        [HideInInspector]
        public ApplySettingsDelegate ApplySettings;
        [Tooltip("Message for debugging")]
        public string debugString;
        [Tooltip("Disable Jawflap or Visemes and use animated jaw and mouth positions")]
        public TrackingType trackingMouth;
        [Tooltip("Disable tracking of user's right fingers and follow animation instead.")]
        public TrackingType trackingRightFingers;
        [Tooltip("Disable EyeLook and use animated eye positions")]
        public TrackingType trackingEyes;
        [Tooltip("Disable tracking of user's right foot and follow animation instead. Also disables procedural footsteps.")]
        public TrackingType trackingRightFoot;
        [Tooltip("Disable tracking of user's left foot and follow animation instead. Also disables procedural footsteps.")]
        public TrackingType trackingLeftFoot;
        [Tooltip("Disable tracking of user's hip and follow animation instead")]
        public TrackingType trackingHip;
        [Tooltip("Disable tracking of user's right hand and follow animation instead.")]
        public TrackingType trackingRightHand;
        [Tooltip("Disable tracking of user's left hand and follow animation instead.")]
        public TrackingType trackingLeftHand;
        [Tooltip("Disable tracking of user's left fingers and follow animation instead.")]
        public TrackingType trackingLeftFingers;

        protected VRC_AnimatorTrackingControl() { }

        [System.Serializable]
        public enum TrackingType
        {
            NoChange = 0,
            Tracking = 1,
            Animation = 2
        }

        [HideInInspector]
        public delegate void InitializationDelegate(VRC_AnimatorTrackingControl obj);
        [HideInInspector]
        public delegate void ApplySettingsDelegate(VRC_AnimatorTrackingControl control, Animator animator);
    }
}
