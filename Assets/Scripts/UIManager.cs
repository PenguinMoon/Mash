using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _rescueCounter;

    [SerializeField]
    private TextMeshProUGUI _helicopterCounter;
    // Start is called before the first frame update
    void Start()
    {
        GameManager._updateSoldierCounter += UpdateSoldierCounter;
        GameManager._updateRescueCounter += UpdateRescueCounter;
    }

    private void UpdateRescueCounter()
    {
        _rescueCounter.text = GameManager.SoldiersRescued.ToString();
    }

    private void UpdateSoldierCounter()
    {
        _helicopterCounter.text = GameManager.SoldiersInHelicopter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
