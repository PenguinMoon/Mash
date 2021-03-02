using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("Starting game");
    }

    public void OpenSettings()
    {
        Debug.Log("Opening settings");
    }

    public void CloseSettings()
    {
        Debug.Log("Close settings");
    }

    public void ExitGame()
    {
        Debug.Log("Exiting game");
        Application.Quit();
    }
}
