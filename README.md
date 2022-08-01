# VRChat Avatar SDK3 Container
A lightweight DLL that replaces the bulky VRChatAvatarSDK3.

## What is this
 - It can replace the VRChat SDK while retaining the original parameters of Avatar.
 - No need to install VRCSDK anymore when converting avatar to games like ChilloutVR.
 - Has a negligible volume, only 47.4 KB.

## Tested with
 - [VRCPhysBone To DynamicBone Converter](https://booth.pm/zh-cn/items/4032295)
 - [vrc3cvr](https://github.com/imagitama/vrc3cvr)

## Tips
 - VRCSDK folder must be deleted before installation.
 - This plugin will not automatically add "VRC_SDK_VRCSDK3" to ScriptingDefineSymbols, you can add it manually if needed.

## Support list
 - Supported local variable
 - Supported enum
 - Supported struct
 - Not supported Static variable 
 - Not supported Method

## Support class list
 - VRC.SDK3.Avatars.Components.VRCAvatarDescriptor
 - VRC.SDK3.Avatars.Components.VRCSpatialAudioSource
 - VRC.SDK3.Avatars.Components.VRCStation
 - VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionParameters
 - VRC.SDK3.Avatars.ScriptableObjects.VRCExpressionsMenu
 - VRC.Core.PipelineManager
 - VRC.Dynamics.CollisionScene
 - VRC.Dynamics.ContactBase
 - VRC.Dynamics.ContactReceiver
 - VRC.Dynamics.ContactSender
 - VRC.Dynamics.VRCContactReceiver
 - VRC.Dynamics.VRCPhysBoneBase
 - VRC.Dynamics.VRCPhysBoneColliderBase
 - VRC.SDK3.Dynamics.Contact.Components.VRCContactReceiver
 - VRC.SDK3.Dynamics.Contact.Components.VRCContactSender
 - VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone
 - VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBoneCollider
 - VRC.SDK3.VRCTestMarker
 - VRC.SDKBase.IAnimParameterAccess
 - VRC.SDKBase.VRC_AvatarDescriptor
 - VRC.SDKBase.VRC_SpatialAudioSource
 - VRC.SDKBase.VRCCustomAction
 - VRC.SDKBase.VRCStation
 
## Version history

**V0.1 July 29, 2022**
 - Initial release
