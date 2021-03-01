using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int _soldiersRescued = 0;
    private static int _soldiersInHelicopter = 0;

    public delegate void UpdateCounter();
    public static event  UpdateCounter _updateSoldierCounter;
    public static event UpdateCounter _updateRescueCounter;

    private void Update()
    {
        
    }

    public static bool PickUpSoldier()
    {
        if (_soldiersInHelicopter >= 3) return false;
        _soldiersInHelicopter++;
        _updateSoldierCounter.Invoke();
        return true;
    }

    public static void DropOffSoldiers()
    {
        _soldiersRescued += _soldiersInHelicopter;
        _soldiersInHelicopter = 0;
        _updateRescueCounter.Invoke();
        _updateSoldierCounter.Invoke();
    }

    public static void GameOver()
    {

    }

    public static void GameWon()
    {

    }

    public static int SoldiersRescued
    {
        get{
            return _soldiersRescued;
        }
    }

    public static int SoldiersInHelicopter
    {
        get
        {
            return _soldiersInHelicopter;
        }
    }
}
