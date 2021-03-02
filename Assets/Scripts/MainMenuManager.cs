using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _mainMenuPanel;

    [SerializeField]
    private GameObject _settingsPanel;


    private void Awake()
    {
        _mainMenuPanel.SetActive(true);
        _settingsPanel.SetActive(false);
    }

    public void StartGame()
    {
        SceneLoader.Instance.LoadGame();
        Debug.Log("Starting game");
    }

    public void OpenSettings()
    {
        _mainMenuPanel.SetActive(false);
        _settingsPanel.SetActive(true);
        Debug.Log("Opening settings");
    }

    public void CloseSettings()
    {
        _mainMenuPanel.SetActive(true);
        _settingsPanel.SetActive(false);
        Debug.Log("Close settings");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game");
        Application.Quit();
    }
}
