using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDK3.Avatars.ScriptableObjects;

namespace VRC.SDK3.Avatars.Components
{
    public class VRCAvatarDescriptor : SDKBase.VRC_AvatarDescriptor
    {

        public const float COLLIDER_MAX_SIZE = 6;
        public bool customExpressions;
        public ColliderConfig collider_fingerLittleR;
        public ColliderConfig collider_fingerRingR;
        public ColliderConfig collider_fingerMiddleR;
        public ColliderConfig collider_fingerIndexR;
        public ColliderConfig collider_fingerLittleL;
        public ColliderConfig collider_fingerRingL;
        public ColliderConfig collider_fingerIndexL;
        public ColliderConfig collider_handL;
        public ColliderConfig collider_handR;
        public ColliderConfig collider_footL;
        public ColliderConfig collider_footR;
        public ColliderConfig collider_torso;
        public ColliderConfig collider_fingerMiddleL;
        public bool autoLocomotion;
        public ColliderConfig collider_head;
        public VRCExpressionsMenu expressionsMenu;
        public VRCExpressionParameters expressionParameters;
        public CustomEyeLookSettings customEyeLookSettings;
        public bool customizeAnimationLayers;
        public bool enableEyeLook;
        public CustomAnimLayer[] specialAnimationLayers;
        public ScriptableObject AnimationPreset;
        [HideInInspector]
        public List<DebugHash> animationHashSet;
        public bool autoFootsteps;
        public CustomAnimLayer[] baseAnimationLayers;

        [System.Serializable]
        public enum AnimLayerType
        {
            Base = 0,
            Deprecated0 = 1,
            Additive = 2,
            Gesture = 3,
            Action = 4,
            FX = 5,
            Sitting = 6,
            TPose = 7,
            IKPose = 8
        }
        [System.Serializable]
        public enum EyelidType
        {
            None = 0,
            Bones = 1,
            Blendshapes = 2
        }

        [System.Serializable]
        public struct DebugHash
        {
            public int hash;
            public string name;
        }
        [System.Serializable]
        public struct CustomAnimLayer
        {
            public bool isEnabled;
            public AnimLayerType type;
            public RuntimeAnimatorController animatorController;
            public AvatarMask mask;
            public bool isDefault;
        }
        [System.Serializable]
        public struct CustomEyeLookSettings
        {
            public EyeMovements eyeMovement;
            public int[] eyelidsBlendshapes;
            public SkinnedMeshRenderer eyelidsSkinnedMesh;
            public EyelidRotations eyelidsLookingDown;
            public EyelidRotations eyelidsLookingUp;
            public EyelidRotations eyelidsClosed;
            public EyelidRotations eyelidsDefault;
            public Transform lowerRightEyelid;
            public Transform lowerLeftEyelid;
            public Transform upperRightEyelid;
            public EyelidType eyelidType;
            public EyeRotations eyesLookingRight;
            public EyeRotations eyesLookingLeft;
            public EyeRotations eyesLookingDown;
            public EyeRotations eyesLookingUp;
            public EyeRotations eyesLookingStraight;
            public Transform rightEye;
            public Transform leftEye;
            public Transform upperLeftEyelid;

            public class EyeRotations
            {
                public bool linked;
                public Quaternion left;
                public Quaternion right;

                //public EyeRotations();
            }
            public class EyeMovements
            {
                public float confidence;
                public float excitement;

                //public EyeMovements();
            }
            public class EyelidRotations
            {
                public EyeRotations upper;
                public EyeRotations lower;

                //public EyelidRotations();
            }
        }
        [System.Serializable]
        public struct ColliderConfig
        {
            public bool isMirrored;
            public State state;
            public Transform transform;
            public float radius;
            public float height;
            public Vector3 position;
            public Quaternion rotation;

            public Vector3 axis { get; }

            // public static ColliderConfig Create();

            public enum State
            {
                Automatic = 0,
                Custom = 1,
                Disabled = 2
            }
        }
    }
}
