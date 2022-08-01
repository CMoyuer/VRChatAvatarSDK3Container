using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public class VRC_EventHandler : MonoBehaviour
    {
        public static GetNetworkIdDelegate GetInstigatorId;
        public static LogEventDelegate LogEvent;
        [SerializeField]
        public List<VrcEvent> Events;
        public List<EventInfo> deferredEvents;


        [Serializable]
        public enum VrcEventType
        {
            MeshVisibility = 0,
            AnimationFloat = 1,
            AnimationBool = 2,
            AnimationTrigger = 3,
            AudioTrigger = 4,
            PlayAnimation = 5,
            SendMessage = 6,
            SetParticlePlaying = 7,
            TeleportPlayer = 8,
            RunConsoleCommand = 9,
            SetGameObjectActive = 10,
            SetWebPanelURI = 11,
            SetWebPanelVolume = 12,
            SpawnObject = 13,
            SendRPC = 14,
            ActivateCustomTrigger = 15,
            DestroyObject = 16,
            SetLayer = 17,
            SetMaterial = 18,
            AddHealth = 19,
            AddDamage = 20,
            SetComponentActive = 21,
            AnimationInt = 22,
            AnimationIntAdd = 24,
            AnimationIntSubtract = 25,
            AnimationIntMultiply = 26,
            AnimationIntDivide = 27,
            AddVelocity = 28,
            SetVelocity = 29,
            AddAngularVelocity = 30,
            SetAngularVelocity = 31,
            AddForce = 32,
            SetUIText = 33,
            CallUdonMethod = 34
        }
        [Serializable]
        public enum VrcBroadcastType
        {
            Always = 0,
            Master = 1,
            Local = 2,
            Owner = 3,
            AlwaysUnbuffered = 4,
            MasterUnbuffered = 5,
            OwnerUnbuffered = 6,
            AlwaysBufferOne = 7,
            MasterBufferOne = 8,
            OwnerBufferOne = 9
        }
        [Serializable]
        public enum VrcTargetType
        {
            All = 0,
            Others = 1,
            Owner = 2,
            Master = 3,
            AllBuffered = 4,
            OthersBuffered = 5,
            Local = 6,
            AllBufferOne = 7,
            OthersBufferOne = 8,
            TargetPlayer = 9
        }
        [Serializable]
        public enum VrcBooleanOp
        {
            Unused = -1,
            False = 0,
            True = 1,
            Toggle = 2
        }
        [Serializable]
        public class VrcEvent
        {
            public string Name;
            public VrcEventType EventType;
            public string ParameterString;
            public VrcBooleanOp ParameterBoolOp;
            [HideInInspector]
            public bool ParameterBool;
            public float ParameterFloat;
            public int ParameterInt;
            [HideInInspector]
            public GameObject ParameterObject;
            [SerializeField]
            public GameObject[] ParameterObjects;
            [HideInInspector]
            [SerializeField]
            public byte[] ParameterBytes;
            [HideInInspector]
            [SerializeField]
            public int? ParameterBytesVersion;
            public bool TakeOwnershipOfTarget;
        }
        [Serializable]
        public class EventInfo
        {
            public VrcEvent evt;
            public VrcBroadcastType broadcast;
            public GameObject instagator;
            public float fastForward;
        }

        public delegate int GetNetworkIdDelegate(GameObject obj);
        public delegate void LogEventDelegate(VRC_EventHandler eventHandler, VrcEvent vrcEvent, VrcBroadcastType broadcast, int instagatorId, float fastForward);

    }
}
