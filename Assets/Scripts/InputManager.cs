using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private PlayerControls _playerControls;

    private void Awake()
    {
        if(_instance != null && _instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
        _playerControls = new PlayerControls();
    }

    private void OnEnable()
    {
        _playerControls.Enable();
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }

    public Vector2 GetPlayerMovement()
    {
        return _playerControls.HelicopterActionMapping.Movement.ReadValue<Vector2>();
    }
}
