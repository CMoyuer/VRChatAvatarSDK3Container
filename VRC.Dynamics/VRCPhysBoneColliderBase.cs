using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.Dynamics
{
    public abstract class VRCPhysBoneColliderBase : MonoBehaviour
    {
        [Tooltip("Transform where this collider is placed.  If empty, we use this game object's transform.")]
        public Transform rootTransform;
        public CollisionScene.Shape shape;
        public int playerId;
        [Tooltip("When enabled, this collider treats bones as spheres instead of capsules. This may be advantageous in situations where bones are constantly resting on colliders.  It will also be easier for colliders to pass through bones unintentionally.")]
        public bool bonesAsSpheres;
        [Tooltip("Rotation offset from the root transform.")]
        public Quaternion rotation;
        public bool isGlobalCollider;
        [Tooltip("Height of the capsule along the Y axis.")]
        public float height;
        [Tooltip("Size of the collider extending from its origin.")]
        public float radius;
        [Tooltip("When enabled, this collider contains bones inside its bounds.")]
        public bool insideBounds;
        [Tooltip("Type of collision shape used by this collider.")]
        public ShapeType shapeType;
        [Tooltip("Position offset from the root transform.")]
        public Vector3 position;

        public Vector3 axis { get; }

        [Serializable]
        public enum ShapeType
        {
            Sphere = 0,
            Capsule = 1,
            Plane = 2
        }
    }
}
