using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDK3.Avatars.ScriptableObjects
{
    public class VRCExpressionParameters : ScriptableObject
    {
        public const int MAX_PARAMETER_COST = 256;
        public Parameter[] parameters;
        [System.Serializable]
        public enum ValueType
        {
            Int = 0,
            Float = 1,
            Bool = 2
        }
        [System.Serializable]
        public class Parameter
        {
            public string name;
            public ValueType valueType;
            public bool saved;
            public float defaultValue;
        }
    }
}
