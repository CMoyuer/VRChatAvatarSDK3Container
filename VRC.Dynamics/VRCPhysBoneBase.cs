using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;

namespace VRC.Dynamics
{
    public abstract class VRCPhysBoneBase : MonoBehaviour
    {
        public const string PARAM_ISGRABBED = "_IsGrabbed";
        public const string PARAM_ANGLE = "_Angle";
        public const string PARAM_STRETCH = "_Stretch";
        public static Action<VRCPhysBoneBase> OnInitialize;
        public static Func<int, int, bool> OnVerifyCollision;
        [Range(0, 1)]
        public float limitOpacity;
        public bool showGizmos;
        [Tooltip("Keyname used to provide multiple parameters to the avatar controller.")]
        public string parameter;
        [Tooltip("Allows bone transforms to be animated.  Each frame bone rest position will be updated according to what was animated.")]
        public bool isAnimated;
        public AnimationCurve maxStretchCurve;
        [Range(0, 5)]
        [Tooltip("Maximum amount the bones can stretch when being grabbed.  Actual length based on each bone's original rest length.")]
        public float maxStretch;
        [Range(0, 1)]
        [Tooltip("Controls how grabbed bones move.\nA value of zero results in bones using pull & spring to reach the grabbed position.\nA value of one results in bones immediately moving to the grabbed position.")]
        public float grabMovement;
        // [FormerlySerializedAs("isPoseable")]
        [Tooltip("Allows players to pose the bones after grabbing.")]
        public bool allowPosing;
        // [FormerlySerializedAs("isGrabbable")]
        [Tooltip("Allows players to grab the bones.")]
        public bool allowGrabbing;
        public Vector3 staticFreezeAxis;
        public bool configHasUpdated;
        public List<Bone> bones;
        public Action OnPoseUpdated;
        public ulong chainId;
        public AnimationCurve limitRotationZCurve;
        public int playerId;
        public bool collidersHaveUpdated;
        public CollisionScene.Shape shape;
        public List<CollisionRecord> collisionRecords;
        public bool param_IsGrabbedValue;
        public float param_AngleValue;
        public float param_StretchValue;
        public IAnimParameterAccess param_IsGrabbed;
        public IAnimParameterAccess param_Angle;
        public IAnimParameterAccess param_Stretch;
        public int maxBoneChainIndex;
        public AnimationCurve limitRotationYCurve;
        [Range(0, 1)]
        public float boneOpacity;
        [Tooltip("Rotates the angular limits on each axis.")]
        public Vector3 limitRotation;
        [Tooltip("Determines how forces are applied.  Certain kinds of motion may require using a specific integration type.")]
        public IntegrationType integrationType;
        public AnimationCurve limitRotationXCurve;
        [Tooltip("List of ignored transforms that shouldn't be affected by this component.  Ignored transforms automatically include any of that transform's children.")]
        public List<Transform> ignoreTransforms;
        [Tooltip("Vector used to create additional bones at each endpoint of the chain. Only used if the value is non-zero.")]
        public Vector3 endpointPosition;
        [Tooltip("Determines how transforms with multiple children are handled. By default those transforms are ignored.")]
        public MultiChildType multiChildType;
        [Range(0, 1)]
        [Tooltip("Amount of force used to return bones to their rest position.")]
        public float pull;
        public AnimationCurve pullCurve;
        [Range(0, 1)]
        [Tooltip("Amount bones will wobble when trying to reach their rest position.")]
        public float spring;
        public AnimationCurve springCurve;
        [Range(0, 1)]
        [Tooltip("Amount bones will try and stay at their current orientation.")]
        public float stiffness;
        public AnimationCurve stiffnessCurve;
        [Range(-1, 1)]
        [Tooltip("Amount of gravity applied to bones.  Positive value pulls bones down, negative pulls upwards.")]
        public float gravity;
        public AnimationCurve gravityCurve;
        [Range(0, 1)]
        [Tooltip("Reduces gravity while bones are at their rest orientation.  Gravity will increase as bones rotate away from their rest orientation, reaching full gravity at 90 degress from rest.")]
        public float gravityFalloff;
        [Tooltip("The transform where this component begins.  If left blank, we assume we start at this game object.")]
        public Transform rootTransform;
        [Tooltip("Determines how immobile is calculated.\n\nAll Motion - Reduces any motion as calculated from the root transform's parent.World - Reduces positional movement from locomotion, any movement due to animations or IK still affect bones normally.\n\n")]
        public ImmobileType immobileType;
        public AnimationCurve gravityFalloffCurve;
        public AnimationCurve maxAngleZCurve;
        [Range(0, 90)]
        [Tooltip("Maximum angle each bone can rotate from its rest position.")]
        public float maxAngleZ;
        [Range(0, 180)]
        [Tooltip("Maximum angle each bone can rotate from its rest position.")]
        public float maxAngleX;
        [Tooltip("Type of angular limit applied to each bone.")]
        public LimitType limitType;
        [Tooltip("List of colliders that specifically collide with these bones.")]
        public List<VRCPhysBoneColliderBase> colliders;
        public AnimationCurve maxAngleXCurve;
        [Tooltip("Collision radius around each bone.  Used for both collision and grabbing.")]
        public float radius;
        [Tooltip("Allows collision with colliders other than the ones specified on this component.  Currently the only other colliders are each player's hands as defined by their avatar.")]
        public bool allowCollision;
        public AnimationCurve immobileCurve;
        [Range(0, 1)]
        [Tooltip("Reduces the effect movement has on bones. The greater the value the less motion affects the chain as determined by the Immobile Type.")]
        public float immobile;
        public AnimationCurve radiusCurve;

        [Serializable]
        public enum IntegrationType
        {
            Simplified = 0,
            Advanced = 1
        }
        [Serializable]
        public enum MultiChildType
        {
            Ignore = 0,
            First = 1,
            Average = 2
        }
        [Serializable]
        public enum ImmobileType
        {
            AllMotion = 0,
            World = 1
        }
        [Serializable]
        public enum LimitType
        {
            None = 0,
            Angle = 1,
            Hinge = 2,
            Polar = 3
        }
        [Serializable]
        public struct Bone
        {
            public Transform transform;
            public int parentIndex;
            public int childIndex;
            public int boneChainIndex;
            public int childCount;
            public Vector3 averageChildPos;
            public Vector3 restPosition;
            public Quaternion restRotation;
            public Vector3 restScale;
            public bool sphereCollision;

            public bool isEndBone { get; }
        }
        [Serializable]
        public struct CollisionRecord
        {
            public CollisionScene.Shape shape;
            public VRCPhysBoneColliderBase collider;
        }
    }
}
