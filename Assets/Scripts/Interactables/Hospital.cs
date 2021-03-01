using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        DropOffSoldier();
    }

    private void DropOffSoldier()
    {
        GameManager.DropOffSoldiers();
        Debug.Log("soldiers dropped off");
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
