using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;

namespace VRC.Dynamics
{
    public class ContactReceiver : ContactBase
    {
        [Tooltip("Allow this contact to be affected by yourself.")]
        public bool allowSelf;
        public float paramValue;
        public float collisionValue;
        [Tooltip("Minimum velocity needed from an incoming collider to affect this trigger.")]
        public float minVelocity;
        public IAnimParameterAccess paramAccess;
        [Tooltip("How the receiver reacts to incomming collisions and sets the parameter value.")]
        public ReceiverType receiverType;
        [Tooltip("Limit this contact to only work on the local client.")]
        public bool localOnly;
        [Tooltip("Allow this contact to be affected by other people.")]
        public bool allowOthers;
        [Tooltip("The parameter updated on the animation controller.  This parameter DOES NOT need to be defined on the avatar descriptor.")]
        public string parameter;
        [Serializable]
        public enum ReceiverType
        {
            Constant = 0,
            OnEnter = 1,
            Proximity = 2
        }
    }
}
