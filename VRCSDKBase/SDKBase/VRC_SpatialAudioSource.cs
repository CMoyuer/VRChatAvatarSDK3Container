using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.SDKBase
{
    public abstract class VRC_SpatialAudioSource : MonoBehaviour
    {
        [Tooltip("Loudness increase in decibels, can be negative.")]
        public float Gain;
        [Tooltip("Distance where loudness falls off to zero, in meters.")]
        public float Far;
        [Tooltip("Distance where loudness begins to falloff, in meters. Default of 0 ensures accurate spatialization.")]
        public float Near;
        [Tooltip("Radius in meters of a spherical shaped sound source. Default of 0 simulates a point-source (recommended).")]
        public float VolumetricRadius;
        [Tooltip("Enable Spatialization. Uncheck only for directionless audio.")]
        public bool EnableSpatialization;
        [Tooltip("Use the AudioSource '3D Sound Settings' volume curve. If unchecked, use Inverse Square falloff.")]
        public bool UseAudioSourceVolumeCurve;

        public delegate void InitializationDelegate(VRC_SpatialAudioSource obj);
    }
}
