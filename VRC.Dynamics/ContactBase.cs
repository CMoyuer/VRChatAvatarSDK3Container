using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.Dynamics
{
    public abstract class ContactBase : MonoBehaviour
    {
        public const float MAX_SIZE = 6;
        public const int MAX_COLLISION_TAGS = 16;
        public static Func<int, int, bool> OnValidatePlayers;
        public static Func<ContactBase, bool> OnInitialize;
        [Tooltip("Transform where this contact is placed.  If empty, we use this game object's transform.")]
        public Transform rootTransform;
        public CollisionScene.Shape shape;
        public bool allowInit;
        [Tooltip("List of strings that specify what it can affect/be affected by.  For a successful collision to occur, both the sender and receiver need at least one matching pair of strings.  Collision tags are case sensitive.\n")]
        public List<string> collisionTags;
        public int playerId;
        [Tooltip("Position offset from the root transform.")]
        public Vector3 position;
        [Tooltip("Height of the capsule along the chosen axis.")]
        public float height;
        [Tooltip("Size of the collider extending from its origin.")]
        public float radius;
        [Tooltip("Type of collision shape used by this contact.")]
        public ShapeType shapeType;
        [Tooltip("Rotation offset from the root transform.")]
        public Quaternion rotation;

        public Vector3 axis { get; }
        [Serializable]
        public enum ShapeType
        {
            Sphere = 0,
            Capsule = 1
        }
    }
}
