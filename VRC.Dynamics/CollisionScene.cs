using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.Dynamics
{
    public class CollisionScene
    {
        [Serializable]
        public enum ShapeType
        {
            None = 0,
            AABB = 1,
            Sphere = 2,
            Capsule = 3,
            Finger = 4,
            Plane = 5
        }
        [Serializable]
        public struct ShapeData
        {
            public ShapeType shapeType;
            public int collisionCount;
            public float outRadius;
            public Vector3 outPos1;
            public Vector3 outPos0;
            public float angularSpeed;
            // public float3 angularNormal;
            // public float3 velocity;
            public Vector3Int nextBoundsMax;
            public Vector3Int boundsMax;
            public Vector3Int nextBoundsMin;
            public Bounds bounds;
            public bool isCollider;
            public bool isReceiver;
            public float maxSize;
            public Vector3 axis;
            public float height;
            public float radius;
            public Vector3 center;
            public Vector3Int boundsMin;
        }
        public struct TransformData
        {
            public Vector3 position;
            public Quaternion rotation;
            public float scale;
            public Vector3 lastPosition;
            public Quaternion lastRotation;
        }

        public class Shape
        {
            public Transform transform0;
            public Transform transform1;
            public ShapeType shapeType;
            public Vector3 center;
            public float radius;
            public float height;
            public Vector3 axis;
            public float maxSize;
            public bool isReceiver;
            public bool isCollider;
            public Action<Shape> OnEnter;
            public Action<Shape> OnExit;
            public Action OnIdUpdated;
            public MonoBehaviour component;

            public int id { get; set; }
        }
    }
}
