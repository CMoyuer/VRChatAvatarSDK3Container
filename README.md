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
 - VRC.SDK3.Dynamics.Contact.Components.VRCContactReceiver
 - VRC.SDK3.Dynamics.Contact.Components.VRCContactSender
 - VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBone
 - VRC.SDK3.Dynamics.PhysBone.Components.VRCPhysBoneCollider
 - VRC.Dynamics.CollisionScene
 - VRC.Dynamics.ContactBase
 - VRC.Dynamics.ContactReceiver
 - VRC.Dynamics.ContactSender
 - VRC.Dynamics.VRCContactReceiver
 - VRC.Dynamics.VRCPhysBoneBase
 - VRC.Dynamics.VRCPhysBoneColliderBase
 - VRC.SDK3.VRCTestMarker
 - VRC.SDKBase.IAnimParameterAccess
 - VRC.SDKBase.VRC_AvatarDescriptor
 - VRC.SDKBase.VRC_SpatialAudioSource
 - VRC.SDKBase.VRCCustomAction
 - VRC.SDKBase.VRCStation
 
## Some screenshot
![VRCAvatarDescriptor](https://user-images.githubusercontent.com/51113234/182151065-f092508b-8559-4842-8277-beb09c923e2e.png)
![VRCExpressionsMenu](https://user-images.githubusercontent.com/51113234/182151074-4c5d3587-fb3d-4a74-87ba-8e351a12d742.png)
![VRCExpressionParameters](https://user-images.githubusercontent.com/51113234/182151086-3cba3c6f-4ee3-4f6e-b410-3a572f884b26.png)
![VRCPhysBone](https://user-images.githubusercontent.com/51113234/182151096-ab6108f1-3d73-4918-9ee8-a7b3e8c48e7a.png)
![VRCPhysBoneCollider](https://user-images.githubusercontent.com/51113234/182151103-90d7d7c8-9881-4871-9561-310c7e80a719.png)



## Version history
**V0.1 July 29, 2022**
 - Initial release
