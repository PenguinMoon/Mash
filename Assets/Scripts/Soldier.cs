using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour, IInteractable
{
    public void Interact()
    { 
        PickupSoldier();
    }

    private void PickupSoldier()
    {
        Debug.Log("Soldier picked up");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
