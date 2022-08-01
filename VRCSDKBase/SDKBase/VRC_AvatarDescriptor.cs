using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace VRC.SDKBase
{
    public class VRC_AvatarDescriptor :MonoBehaviour
    {
        public string Name;
        public Quaternion portraitCameraRotationOffset;
        public Vector3 portraitCameraPositionOffset;
        public string unityVersion;
        [HideInInspector]
        public object apiAvatar;
        public string[] VisemeBlendShapes;
        public SkinnedMeshRenderer VisemeSkinnedMesh;
        public string MouthOpenBlendShapeName;
        public Quaternion lipSyncJawClosed;
        public Transform lipSyncJawBone;
        public LipSyncStyle lipSync;
        public bool ScaleIPD;
        public AnimationSet Animations;
        public Vector3 ViewPosition;
        public Quaternion lipSyncJawOpen;


        [System.Serializable]
        public enum LipSyncStyle
        {
            Default = 0,
            JawFlapBone = 1,
            JawFlapBlendShape = 2,
            VisemeBlendShape = 3,
            VisemeParameterOnly = 4
        }
        [System.Serializable]
        public enum AnimationSet
        {
            Male = 0,
            Female = 1,
            None = 2
        }
        [System.Serializable]
        public enum Viseme
        {
            sil = 0,
            PP = 1,
            FF = 2,
            TH = 3,
            DD = 4,
            kk = 5,
            CH = 6,
            SS = 7,
            nn = 8,
            RR = 9,
            aa = 10,
            E = 11,
            ih = 12,
            oh = 13,
            ou = 14,
            Count = 15
        }
    }
}
