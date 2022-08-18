# VRChat Avatar SDK3 Container
A lightweight DLL that replaces the bulky VRChatAvatarSDK3.

## What is this
 - It can replace the VRChat SDK while retaining the original parameters of Avatar.
 - No need to install VRCSDK anymore when converting avatar to games like ChilloutVR.
 - Develop based on the **VRCSDK3-AVATAR-2022.07.26.21.45_Public**
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
 - VRC.SDK3.Avatars.Components.VRCAnimatorLayerControl
 - VRC.SDK3.Avatars.Components.VRCAnimatorLocomotionControl
 - VRC.SDK3.Avatars.Components.VRCAnimatorTemporaryPoseSpace
 - VRC.SDK3.Avatars.Components.VRCAnimatorTrackingControl
 - VRC.SDK3.Avatars.Components.VRCAvatarParameterDriver
 - VRC.SDK3.Avatars.Components.VRCPlayableLayerControl
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
 - VRC.SDKBase.VRC_AnimatorLayerControl
 - VRC.SDKBase.VRC_AnimatorLocomotionControl
 - VRC.SDKBase.VRC_AnimatorTemporaryPoseSpace
 - VRC.SDKBase.VRC_AnimatorTrackingControl
 - VRC.SDKBase.VRC_AvatarParameterDriver
 - VRC.SDKBase.VRC_PlayableLayerControl
 
## Some screenshot
![VRCAvatarDescriptor](https://user-images.githubusercontent.com/51113234/182151065-f092508b-8559-4842-8277-beb09c923e2e.png)
![VRCExpressionsMenu](https://user-images.githubusercontent.com/51113234/182151074-4c5d3587-fb3d-4a74-87ba-8e351a12d742.png)
![VRCExpressionParameters](https://user-images.githubusercontent.com/51113234/182151086-3cba3c6f-4ee3-4f6e-b410-3a572f884b26.png)
![VRCPhysBone](https://user-images.githubusercontent.com/51113234/182151096-ab6108f1-3d73-4918-9ee8-a7b3e8c48e7a.png)
![VRCPhysBoneCollider](https://user-images.githubusercontent.com/51113234/182151103-90d7d7c8-9881-4871-9561-310c7e80a719.png)
![VRCAvatarParameterDriver](https://user-images.githubusercontent.com/51113234/185279379-338bda24-9faf-4a73-a931-583c9cbf87db.png)

## Version history

**V0.2 August 18, 2020**
 - Supprot all state behaviors
 
**V0.1 July 29, 2022**
 - Initial release
