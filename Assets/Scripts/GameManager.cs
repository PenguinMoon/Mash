using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int _soldiersPickedUp = 0;
    public static int _soldiersInHelicopter = 0;

    private void Update()
    {
        
    }

    public static void DropOffSoldiers()
    {
        _soldiersPickedUp += _soldiersInHelicopter;
        _soldiersInHelicopter = 0;
    }

    public static void GameOver()
    {

    }

    public static void GameWon()
    {

    }
}
