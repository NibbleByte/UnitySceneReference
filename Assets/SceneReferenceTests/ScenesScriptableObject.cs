using DevLocker.Utils;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(ScenesScriptableObject), menuName = nameof(ScenesScriptableObject))]
public class ScenesScriptableObject : ScriptableObject
{
	public SceneReference TargetScene;

	public SceneReference[] MoreScene;
}
