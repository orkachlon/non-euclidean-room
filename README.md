# Non Euclidean Room
Final project for the course "The visual culture of science" in Bezalel.

## Description
This project aims to introduce a more intuitive way of understanding non Euclidean spaces, by letting the user wander in a room where space can curve.</br>
Through this project experience space distortion, expansion, compression and curvature as they might seem through your eyes.

![Example 1](./md/ner_1.gif)

![Example 2](./md/ner_2.gif)

![Example 2](./md/ner_3.gif)

![Example 2](./md/ner_4.gif)

Video:</br>
[![Click to play video](https://img.youtube.com/vi/gblDxUZDRX0/0.jpg)](https://www.youtube.com/watch?v=gblDxUZDRX0)

## Installation
### Dependencies
### Unity
This project was made with Unity 2019.1 so any newer version should work as well.</br>
In order to play the game you must build it in Unity first and then execute the resulting file.

## Instructions
Move around with the arrow keys or with WASD, use the spacebar to jump, and look around with the mouse.</br>
To exit press ESC.

## Files
### Directory Tree
```
.
├── Assets
│   ├── HDRI
│   │   ├── Skybox_Mat.mat
│   │   ├── Skybox_Mat.mat.meta
│   │   ├── noon_grass_4k.hdr
│   │   └── noon_grass_4k.hdr.meta
│   ├── Materials
│   │   ├── Black.mat
│   │   ├── Black.mat.meta
│   │   ├── Blue.mat
│   │   ├── Blue.mat.meta
│   │   ├── CameraMat1.mat
│   │   ├── CameraMat1.mat.meta
│   │   ├── CameraMat2.mat
│   │   ├── CameraMat2.mat.meta
│   │   ├── CameraMat3.mat
│   │   ├── CameraMat3.mat.meta
│   │   ├── CameraShortEntranceMat.mat
│   │   ├── CameraShortEntranceMat.mat.meta
│   │   ├── CameraShortExitMat.mat
│   │   ├── CameraShortExitMat.mat.meta
│   │   ├── CorridorEntranceMat.mat
│   │   ├── CorridorEntranceMat.mat.meta
│   │   ├── CorridorExitMat.mat
│   │   ├── CorridorExitMat.mat.meta
│   │   ├── Cycle1Left.mat
│   │   ├── Cycle1Left.mat.meta
│   │   ├── Cycle1Right.mat
│   │   ├── Cycle1Right.mat.meta
│   │   ├── Cycle2Left.mat
│   │   ├── Cycle2Left.mat.meta
│   │   ├── Cycle2Right.mat
│   │   ├── Cycle2Right.mat.meta
│   │   ├── CycleEntranceMat.mat
│   │   ├── CycleEntranceMat.mat.meta
│   │   ├── CycleExitMat.mat
│   │   ├── CycleExitMat.mat.meta
│   │   ├── DoubleCorridorEntranceMat.mat
│   │   ├── DoubleCorridorEntranceMat.mat.meta
│   │   ├── DoubleCorridorExitMat.mat
│   │   ├── DoubleCorridorExitMat.mat.meta
│   │   ├── Green.mat
│   │   ├── Green.mat.meta
│   │   ├── Orange.mat
│   │   ├── Orange.mat.meta
│   │   ├── Purple.mat
│   │   ├── Purple.mat.meta
│   │   ├── Red.mat
│   │   ├── Red.mat.meta
│   │   ├── Room3CornerMat.mat
│   │   ├── Room3CornerMat.mat.meta
│   │   ├── Room4CorenerMat.mat
│   │   ├── Room4CorenerMat.mat.meta
│   │   ├── White.mat
│   │   ├── White.mat.meta
│   │   ├── Yellow.mat
│   │   └── Yellow.mat.meta
│   ├── Models
│   │   ├── gate.blend
│   │   ├── gate.blend.meta
│   │   ├── gate.blend1
│   │   ├── gate.blend1.meta
│   │   ├── gate.fbx
│   │   └── gate.fbx.meta
│   ├── Prefabs
│   │   ├── CornerPortal.prefab
│   │   ├── CornerPortal.prefab.meta
│   │   ├── CornerPortalPlaceholder.prefab
│   │   ├── CornerPortalPlaceholder.prefab.meta
│   │   ├── CorridorLong.prefab
│   │   ├── CorridorLong.prefab.meta
│   │   ├── CorridorLongPlaceholder.prefab
│   │   ├── CorridorLongPlaceholder.prefab.meta
│   │   ├── Player.prefab
│   │   ├── Player.prefab.meta
│   │   ├── Portal.prefab
│   │   ├── Portal.prefab.meta
│   │   ├── PortalPlaceholder2.prefab
│   │   ├── PortalPlaceholder2.prefab.meta
│   │   ├── Portal_old.prefab
│   │   ├── Portal_old.prefab.meta
│   │   ├── gate.prefab
│   │   └── gate.prefab.meta
│   ├── ProBuilder Data
│   │   ├── Default Material Palette.asset
│   │   └── Default Material Palette.asset.meta
│   ├── Scenes
│   │   ├── Level_1.unity
│   │   ├── Level_1.unity.meta
│   │   ├── Main.unity
│   │   └── Main.unity.meta
│   ├── Scripts
│   │   ├── Corner
│   │   │   ├── CornerCamera.cs
│   │   │   └── CornerCamera.cs.meta
│   │   ├── Corridor
│   │   │   ├── CorridorCamera.cs
│   │   │   ├── CorridorCamera.cs.meta
│   │   │   ├── CorridorTeleporter.cs
│   │   │   ├── CorridorTeleporter.cs.meta
│   │   │   ├── ShortCorridorDoubleCamera.cs
│   │   │   └── ShortCorridorDoubleCamera.cs.meta
│   │   ├── Managers
│   │   │   ├── GeneralManager.cs
│   │   │   ├── GeneralManager.cs.meta
│   │   │   ├── PortalSetup.cs
│   │   │   ├── PortalSetup.cs.meta
│   │   │   ├── ProtalTextureSetup.cs
│   │   │   └── ProtalTextureSetup.cs.meta
│   │   ├── Player
│   │   │   ├── PlayerLook.cs
│   │   │   ├── PlayerLook.cs.meta
│   │   │   ├── PlayerMove.cs
│   │   │   ├── PlayerMove.cs.meta
│   │   │   ├── PlayerMovement.cs
│   │   │   └── PlayerMovement.cs.meta
│   │   └── Portal
│   │       ├── DirectionTeleportHelper.cs
│   │       ├── DirectionTeleportHelper.cs.meta
│   │       ├── Disabler.cs
│   │       ├── Disabler.cs.meta
│   │       ├── DoublePortalTeleport.cs
│   │       ├── DoublePortalTeleport.cs.meta
│   │       ├── PortalTeleporter.cs
│   │       ├── PortalTeleporter.cs.meta
│   │       ├── ProtalCamera.cs
│   │       └── ProtalCamera.cs.meta
│   └── Shaders
│       ├── ScreenCutoutShader.shader
│       └── ScreenCutoutShader.shader.meta
├── Packages
│   └── manifest.json
│   ProjectSettings
│   ├── AudioManager.asset
│   ├── ClusterInputManager.asset
│   ├── DynamicsManager.asset
│   ├── EditorBuildSettings.asset
│   ├── EditorSettings.asset
│   ├── GraphicsSettings.asset
│   ├── InputManager.asset
│   ├── NavMeshAreas.asset
│   ├── NetworkManager.asset
│   ├── Packages
│   │   └── com.unity.probuilder
│   │       └── Settings.json
│   ├── Physics2DSettings.asset
│   ├── PresetManager.asset
│   ├── ProjectSettings.asset
│   ├── ProjectVersion.txt
│   ├── QualitySettings.asset
│   ├── TagManager.asset
│   ├── TimeManager.asset
│   ├── UnityConnectSettings.asset
│   ├── VFXManager.asset
│   └── XRSettings.asset
├── Presentation
|   ├── 1.jpg
|   ├── .
|   ├── .
|   ├── .
|   └── 37.jpg
└── README.md
```
## References
[Brackeys Portal tutorial](https://www.youtube.com/watch?v=cuQao3hEKfs&ab_channel=Brackeys) on how to create portals in Unity.</br>
[CodeParade's video](https://www.youtube.com/watch?v=kEB11PQ9Eo8) on non euclidean geometry.
