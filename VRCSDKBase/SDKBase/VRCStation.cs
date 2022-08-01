using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRCStation : MonoBehaviour
    {
        public Mobility PlayerMobility;
        public bool canUseStationFromStation;
        public RuntimeAnimatorController animatorController;
        public bool disableStationExit;
        public bool seated;
        public Transform stationEnterPlayerLocation;
        public Transform stationExitPlayerLocation;
        // public VRC_ObjectApi controlsObject;

        [System.Serializable]
        public enum Mobility
        {
            Mobile = 0,
            Immobilize = 1,
            ImmobilizeForVehicle = 2
        }

        public delegate void InitializationDelegate(VRCStation obj);
    }
}
