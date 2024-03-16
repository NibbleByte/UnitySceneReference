// MIT License Copyright(c) 2024 Filip Slavov, https://github.com/NibbleByte/UnitySceneReference

using DevLocker.Utils;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(ScenesScriptableObject), menuName = nameof(ScenesScriptableObject))]
public class ScenesScriptableObject : ScriptableObject
{
	public SceneReference TargetScene;

	public SceneReference[] MoreScene;
}
