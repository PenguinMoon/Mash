using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    private InputManager _inputManager;
    // Start is called before the first frame update
    void Start()
    {
        _inputManager = InputManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_inputManager.GetPlayerMovement() * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject _gameobject = other.gameObject;
        if (_gameobject == null) return;
        IInteractable _interactable = _gameobject.GetComponent<IInteractable>();
        if (_interactable == null) return;
        _interactable.Interact();
    }
}
