using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _helicopterCounter;
    // Start is called before the first frame update
    void Start()
    {
        GameManager._updateSoldierCounter += UpdateSoldierCounter;
    }

    private void UpdateSoldierCounter()
    {
        _helicopterCounter.text = GameManager.SoldiersInHelicopter.ToString();
        Debug.Log(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
