using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : MonoBehaviour, IInteractable
{
    private AudioSource _audioSource;
    private BoxCollider2D _collider;
    private Vector3 _startingPosition;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _collider = GetComponent<BoxCollider2D>();
        _startingPosition = transform.position;
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
            StartCoroutine(HideSoldier());
        }
        else
        {
            Debug.Log("Soldier not picked up");
        }
    }

    IEnumerator HideSoldier()
    {
        transform.position = new Vector3(float.MaxValue, 0, 0);
        yield return new WaitForSeconds(3);
        transform.position = _startingPosition;
    }
}
