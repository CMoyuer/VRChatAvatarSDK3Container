using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_AvatarParameterDriver : StateMachineBehaviour
    {
        public static Action<VRC_AvatarParameterDriver, Animator> OnApplySettings;
        public List<Parameter> parameters;
        [Tooltip("When true, only the client who is wearing this avatar will use this ParameterDriver.  This option is useful to avoid conflicts from non-deterministic operations like Random or Add across multiple clients.")]
        public bool localOnly;
        [Tooltip("Custom debug message that will be written to the client logs when the ParameterDriver is used.  Be careful to remove these before your final upload as this can spam your log files.")]
        public string debugString;
        public bool initialized;
        public bool isLocalPlayer;
        public bool isEnabled;
        protected VRC_AvatarParameterDriver() { }

        [System.Serializable]
        public enum ChangeType
        {
            Set = 0,
            Add = 1,
            Random = 2,
            Copy = 3
        }

        [System.Serializable]
        public class Parameter
        {
            [Tooltip("The type of operation to be executed")]
            public ChangeType type;
            [Tooltip("Parameter that will be written to")]
            public string name;
            [Tooltip("Source parameter that will be read")]
            public string source;
            [Tooltip("The value used for this operation")]
            public float value;
            [Tooltip("Minimum value to be set")]
            public float valueMin;
            [Tooltip("Maximum value to be set")]
            public float valueMax;
            [Range(0, 1)]
            [Tooltip("Chance the value will be set.  When used with a Bool type, defines the chance the value is set to 1, otherwise it's set to 0.")]
            public float chance;
            [Tooltip("If true, we convert the range of the source and destination values according to the ranges given.")]
            public bool convertRange;
            public float sourceMin;
            public float sourceMax;
            public float destMin;
            public float destMax;
            public object sourceParam;
            public object destParam;
        }
    }
}
