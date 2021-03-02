using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour, IInteractable
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    { 
        PickupSoldier();
    }

    private void PickupSoldier()
    {
        if (GameManager.PickUpSoldier())
        {

            Debug.Log("Soldier picked up");
            _audioSource.Play();
        }
        else
        {
            Debug.Log("Soldier not picked up");
        }
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
