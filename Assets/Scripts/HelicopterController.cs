using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    private InputManager _inputManager;

    [SerializeField]
    private float _movementSpeed = 3.0f;

    void Start()
    {
        _inputManager = InputManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (_inputManager.GetResetButton())
        {
            GameManager.GameReset();
            return;
        }
        transform.Translate(_inputManager.GetPlayerMovement() * _movementSpeed  * Time.deltaTime);
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
