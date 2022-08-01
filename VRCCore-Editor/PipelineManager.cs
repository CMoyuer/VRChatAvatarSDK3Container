using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace VRC.Core
{
    public class PipelineManager: MonoBehaviour
    {
        [HideInInspector]
        public bool launchedFromSDKPipeline;
        [HideInInspector]
        public bool completedSDKPipeline;
        [HideInInspector]
        public string blueprintId;
        [HideInInspector]
        // public APIUser user;
        public ContentType contentType;
        [HideInInspector]
        [Obsolete("Property is not used.")]
        public string assetBundleUnityVersion;
        [HideInInspector]
        public FallbackStatus fallbackStatus;
        [Serializable]
        public enum ContentType
        {
            avatar = 0,
            world = 1
        }
        [Serializable]
        public enum FallbackStatus
        {
            InvalidPlatform = 0,
            InvalidPerformance = 1,
            InvalidRig = 2,
            Valid = 3
        }
    }
}
