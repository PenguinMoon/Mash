// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""HelicopterActionMapping"",
            ""id"": ""d467162c-ce9b-4cc1-a478-64c2b0861011"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""84b58c37-0915-41fa-bcf1-2759ef20e053"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""592f6601-b7b6-4334-8b03-c45dcaa44445"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""9e1a807c-e562-48d9-8ed9-656589a87015"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Continue"",
                    ""type"": ""Button"",
                    ""id"": ""91c54368-62ae-426b-8fc7-8455df2b088f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""25242697-0696-4d8f-b856-87293242d62f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""365ee927-e859-4dd6-8394-532c91da6871"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6d9778d0-1fa3-4e22-895e-284fdfa3b787"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2458e497-366a-485f-a840-239565469728"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""82635dd8-6491-4ac6-a5fa-ad7986601b15"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a904688c-38fd-440d-9c8e-57e8794cd988"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""605b9e1a-9719-438d-9c84-3bf9b4511d86"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""35a88709-72a5-4fb4-bd58-2be5e02f1d6f"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""11e962d3-c202-4578-86ca-a2c1beb326ce"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""defd04fb-ee8e-4cc4-bb10-4cf0fc26ba08"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02cb8722-04ab-41c0-8017-650d694566ab"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""031211b9-2739-4137-9464-f5cf9c1e40c7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd52cf78-9fbf-4a65-abc7-032dd7715156"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Continue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // HelicopterActionMapping
        m_HelicopterActionMapping = asset.FindActionMap("HelicopterActionMapping", throwIfNotFound: true);
        m_HelicopterActionMapping_Movement = m_HelicopterActionMapping.FindAction("Movement", throwIfNotFound: true);
        m_HelicopterActionMapping_Reset = m_HelicopterActionMapping.FindAction("Reset", throwIfNotFound: true);
        m_HelicopterActionMapping_Pause = m_HelicopterActionMapping.FindAction("Pause", throwIfNotFound: true);
        m_HelicopterActionMapping_Continue = m_HelicopterActionMapping.FindAction("Continue", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // HelicopterActionMapping
    private readonly InputActionMap m_HelicopterActionMapping;
    private IHelicopterActionMappingActions m_HelicopterActionMappingActionsCallbackInterface;
    private readonly InputAction m_HelicopterActionMapping_Movement;
    private readonly InputAction m_HelicopterActionMapping_Reset;
    private readonly InputAction m_HelicopterActionMapping_Pause;
    private readonly InputAction m_HelicopterActionMapping_Continue;
    public struct HelicopterActionMappingActions
    {
        private @PlayerControls m_Wrapper;
        public HelicopterActionMappingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_HelicopterActionMapping_Movement;
        public InputAction @Reset => m_Wrapper.m_HelicopterActionMapping_Reset;
        public InputAction @Pause => m_Wrapper.m_HelicopterActionMapping_Pause;
        public InputAction @Continue => m_Wrapper.m_HelicopterActionMapping_Continue;
        public InputActionMap Get() { return m_Wrapper.m_HelicopterActionMapping; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HelicopterActionMappingActions set) { return set.Get(); }
        public void SetCallbacks(IHelicopterActionMappingActions instance)
        {
            if (m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnMovement;
                @Reset.started -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnReset;
                @Pause.started -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnPause;
                @Continue.started -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnContinue;
                @Continue.performed -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnContinue;
                @Continue.canceled -= m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface.OnContinue;
            }
            m_Wrapper.m_HelicopterActionMappingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Continue.started += instance.OnContinue;
                @Continue.performed += instance.OnContinue;
                @Continue.canceled += instance.OnContinue;
            }
        }
    }
    public HelicopterActionMappingActions @HelicopterActionMapping => new HelicopterActionMappingActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IHelicopterActionMappingActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnContinue(InputAction.CallbackContext context);
    }
}
