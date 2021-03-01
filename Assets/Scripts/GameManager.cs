using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int _soldiersRescued = 0;
    public static int _soldiersInHelicopter = 0;

    public delegate void UpdateCounter();
    public static event  UpdateCounter _updateSoldierCounter;

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
    }

    public static void GameOver()
    {

    }

    public static void GameWon()
    {

    }

    public static int SoldiersInHelicopter
    {
        get
        {
            return _soldiersInHelicopter;
        }
    }
}
