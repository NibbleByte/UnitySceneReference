// MIT License Copyright(c) 2024 Filip Slavov, https://github.com/NibbleByte/UnitySceneReference

using DevLocker.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReferenceTester : MonoBehaviour
{
    public SceneReference Scene;

    public ScenesPrefab Prefab;

    public ScenesScriptableObject ScenesScriptableObject;

    [Header("Tested on Awake")]
    public SceneReference SceneCloned;
    public SceneReference SceneEmpty;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        SceneCloned = Scene.Clone();
        SceneEmpty.ScenePath = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            SceneManager.LoadSceneAsync(Scene.ScenePath);
        }


        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            SceneManager.LoadSceneAsync(ScenesScriptableObject.TargetScene.ScenePath);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            SceneManager.LoadSceneAsync(ScenesScriptableObject.MoreScene[0].ScenePath);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            SceneManager.LoadSceneAsync(ScenesScriptableObject.MoreScene[1].ScenePath);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5)) {
            SceneManager.LoadSceneAsync(Prefab.Scene.ScenePath);
        }
    }
}
