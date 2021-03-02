using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GameState
{
    Running,
    Victory,
    Defeat
}

public class GameManager : MonoBehaviour
{
    private static int _totalSoldiers = 20;
    private static int _soldiersLeft = 0;
    private static int _soldiersRescued = 0;
    private static int _soldiersInHelicopter = 0;
    private static GameState _gameState;

    public delegate void UpdateCounter();
    public static event UpdateCounter _updateLeftCounter;
    public static event UpdateCounter _updateHelicopterCounter;
    public static event UpdateCounter _updateRescueCounter;

    public delegate void GameEvent();
    public static event GameEvent _gameWon;
    public static event GameEvent _gameOver;
    public static event GameEvent _gameReset;

    private void Awake()
    {
        InitializeGame();
    }

    private void Start()
    {
        StartGame();
    }

    public static void InitializeGame()
    {
        _soldiersLeft = _totalSoldiers;
        _soldiersRescued = 0;
        _soldiersInHelicopter = 0;

        _gameState = GameState.Running;
    }

    public static void StartGame()
    {
        _updateLeftCounter.Invoke();
        _updateHelicopterCounter.Invoke();
        _updateRescueCounter.Invoke();
    }

    public static void GameWon()
    {
        _gameState = GameState.Victory;
        if (_gameWon != null) _gameWon.Invoke();
        else
        {
            Debug.Log("_gameWon is null or has nothing to invoke");
        }
    }

    public static void GameOver()
    {
        _gameState = GameState.Defeat;
        if(_gameOver != null) _gameOver.Invoke();
        else
        {
            Debug.Log("_gameOver is null or has nothing to invoke");
        }
    }

    public static void GameReset()
    {
        InitializeGame();
        StartGame();
        if(_gameReset != null) _gameReset.Invoke();
        else
        {
            Debug.Log("_gameReset is null or has nothing to invoke");
        }
    }

    public static void HitTree()
    {
        GameOver();
    }

    public static bool PickUpSoldier()
    {
        if (_gameState != GameState.Running) return false;
        if (_soldiersInHelicopter >= 3) return false;
        _soldiersInHelicopter++;
        _soldiersLeft--;
        _updateLeftCounter.Invoke();
        _updateHelicopterCounter.Invoke();
        return true;
    }

    public static bool DropOffSoldiers()
    {
        if (_soldiersInHelicopter > 0)
        {
            _soldiersRescued += _soldiersInHelicopter;
            _soldiersInHelicopter = 0;
            _updateRescueCounter.Invoke();
            _updateHelicopterCounter.Invoke();
            if (_soldiersRescued >= _totalSoldiers)
            {
                GameWon();
            }
            return true;
        }
        return false;
    }

    public static int SoldiersLeft
    {
        get { return _soldiersLeft; }
    }

    public static int SoldiersRescued
    {
        get{ return _soldiersRescued; }
    }

    public static int SoldiersInHelicopter
    {
        get { return _soldiersInHelicopter; }
    }
}
