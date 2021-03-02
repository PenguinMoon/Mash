using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterController : MonoBehaviour
{
    private InputManager _inputManager;
    private Rigidbody2D _rigidbody2D;
    private Vector2 _startingPosition;

    [SerializeField]
    private float _movementSpeed = 3.5f;

    void Start()
    {
        _startingPosition = transform.position;
        _inputManager = InputManager.Instance;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        GameManager._gameReset += Reset;
    }

    public void Reset()
    {
        transform.position = _startingPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if (_inputManager.GetResetButton())
        {
            GameManager.GameReset();
            return;
        }
        if (GameManager.CurrentGameState == GameState.Running)
        {
            transform.Translate(_inputManager.GetPlayerMovement() * _movementSpeed * Time.deltaTime);
        }
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
