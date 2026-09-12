<img src="https://raw.githubusercontent.com/NibbleByte/UnitySceneReference/refs/heads/master/Docs/PublishImages/Icon-160.png" width="160" align="right">

# Wise Scene Reference
Keeps reference to a scene asset and tracks it's path in the editor, so it can be used in the game at runtime.

## Why
It's a well known fact that scenes can't be referenced like prefabs, textures etc.
The [Unity SceneManager](https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.html) API works with relative scene paths or names.

Use this class to avoid manually typing and updating scene path strings - it will try to do it for you as best as it can, including when <b>building the player</b>.

## Usage
Just replace any string fields used to store scene paths with SceneReference and you're good to go.

## Installation
* Download the single file directly: [SceneReference](https://github.com/NibbleByte/UnitySceneReference/blob/master/Assets/DevLocker/Utils/SceneReference.cs)
* [Asset Store](https://u3d.as/48zM)
* [OpenUPM](https://openupm.com/packages/devlocker.utils.scenereference) support:
```
npm install -g openupm-cli
openupm add devlocker.utils.scenereference
```
[![openupm](https://img.shields.io/npm/v/devlocker.utils.scenereference?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/devlocker.utils.scenereference/)

* Github upm package - merge this to your `Packages/manifest.json`
```
{
  "dependencies": {
    "devlocker.utils.scenereference": "https://github.com/NibbleByte/UnitySceneReference.git#upm"
}
```

## Features
* The SceneReference class works on lists, scriptable objects, game objects, multiple-select.
* Small button on the right to add or remove from the build settings. The +/- sign and color indicate what the operation would be.
* Paths are updated during build (guaranteed by the [ISerializationCallbackReceiver](https://docs.unity3d.com/ScriptReference/ISerializationCallbackReceiver.html)).

Here is how it looks like:<br/>
![SceneReference](https://raw.githubusercontent.com/NibbleByte/UnitySceneReference/refs/heads/master/Docs/Screenshots/SceneReference.png)

Here is how it looks in the code:<br/>
![SceneReferenceCode](https://raw.githubusercontent.com/NibbleByte/UnitySceneReference/refs/heads/master/Docs/Screenshots/SceneReferenceCode.png)

Here is how it looks in debug mode (what data is stored):<br/>
![SceneReferenceDebug](https://raw.githubusercontent.com/NibbleByte/UnitySceneReference/refs/heads/master/Docs/Screenshots/SceneReferenceDebug.png)

## Credits
Using the [ISerializationCallbackReceiver](https://docs.unity3d.com/ScriptReference/ISerializationCallbackReceiver.html) was inspired by the [unity-scene-reference](https://github.com/JohannesMP/unity-scene-reference) implementation.