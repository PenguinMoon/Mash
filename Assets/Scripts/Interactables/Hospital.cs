using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : MonoBehaviour, IInteractable
{
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        DropOffSoldier();
    }

    private void DropOffSoldier()
    {
        if (GameManager.DropOffSoldiers())
        {
            _audioSource.Play();
            Debug.Log("soldiers dropped off");
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
