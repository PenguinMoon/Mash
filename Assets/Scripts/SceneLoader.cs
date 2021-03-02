using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    private static SceneLoader _instance;

    public static SceneLoader Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public void LoadGame()
    {
        StartCoroutine(LoadSceneAsync(1));
        StartCoroutine(UnloadSceneAsync(0));
    }

    public void LoadMenu()
    {
        StartCoroutine(LoadSceneAsync(0));
        StartCoroutine(UnloadSceneAsync(1));
    }

    IEnumerator LoadSceneAsync(int _sceneNumber)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_sceneNumber);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    IEnumerator UnloadSceneAsync(int _sceneNumber)
    {
        AsyncOperation _asyncUnload = SceneManager.UnloadSceneAsync(_sceneNumber);
        while (!_asyncUnload.isDone)
        {
            yield return null;
        }
    }
}
