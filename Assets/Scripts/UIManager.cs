using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameWonPanel;

    [SerializeField]
    private GameObject _gameOverPanel;

    [SerializeField]
    private TextMeshProUGUI _leftCounter;

    [SerializeField]
    private TextMeshProUGUI _rescueCounter;

    [SerializeField]
    private TextMeshProUGUI _helicopterCounter;

    void Awake()
    {
        GameManager._gameWon += DisplayGameWonScreen;
        GameManager._gameOver += DisplayGameOverScreen;
        GameManager._gameReset += ClearGameStateScreens;
        GameManager._updateLeftCounter += UpdateSoldiersLeftCounter;
        GameManager._updateHelicopterCounter += UpdateSoldierCounter;
        GameManager._updateRescueCounter += UpdateRescueCounter;
        _gameWonPanel.SetActive(false);
        _gameOverPanel.SetActive(false);
    }

    private void UpdateSoldiersLeftCounter()
    {
        _leftCounter.text = GameManager.SoldiersLeft.ToString();
    }

    private void UpdateRescueCounter()
    {
        _rescueCounter.text = GameManager.SoldiersRescued.ToString();
    }

    private void UpdateSoldierCounter()
    {
        _helicopterCounter.text = GameManager.SoldiersInHelicopter.ToString();
    }

    private void DisplayGameWonScreen()
    {
        _gameWonPanel.SetActive(true);
    }

    private void DisplayGameOverScreen()
    {
        _gameOverPanel.SetActive(true);
    }

    private void ClearGameStateScreens()
    {
        _gameWonPanel.SetActive(false);
        _gameOverPanel.SetActive(false);
    }
}
