using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDK3.Avatars.ScriptableObjects
{
    public class VRCExpressionsMenu : ScriptableObject
    {
        public const int MAX_CONTROLS = 8;
        public List<Control> controls;

        [Serializable]
        public class Control
        {
            [Tooltip("(Optional) Label shown in the expression menu.")]
            public string name;
            [Tooltip("(Optional) Icon shown in the expression menu.")]
            public Texture2D icon;
            [Tooltip("Type of control used.")]
            public ControlType type;
            [Tooltip("The specific parameter used by this control in the Animation Controller.")]
            public Parameter parameter;
            [Tooltip("The value the parameter is set to when this control is used.")]
            public float value;
            public Style style;
            public VRCExpressionsMenu subMenu;
            public Parameter[] subParameters;
            public Label[] labels;

            [Serializable]
            public enum ControlType
            {
                Button = 101,
                Toggle = 102,
                SubMenu = 103,
                TwoAxisPuppet = 201,
                FourAxisPuppet = 202,
                RadialPuppet = 203
            }
            [Serializable]
            public enum Style
            {
                Style1 = 0,
                Style2 = 1,
                Style3 = 2,
                Style4 = 3
            }

            [Serializable]
            public struct Label
            {
                [Tooltip("(Optional) Label shown in the expression menu.")]
                public string name;
                [Tooltip("(Optional) Icon shown in the expression menu.")]
                public Texture2D icon;
            }

            [Serializable]
            public class Parameter
            {
                public string name;

                public int hash { get; }

            }
        }
    }
}
