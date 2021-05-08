// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

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
            ""name"": ""PlayerMap"",
            ""id"": ""cb537865-2512-4e6a-b27b-69ebe59dc2d9"",
            ""actions"": [
                {
                    ""name"": ""Walking"",
                    ""type"": ""PassThrough"",
                    ""id"": ""30256d46-ebbd-4891-8922-15a0e291af08"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""0508fd3e-8164-4089-a92d-4097f3f882cd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c194bead-aafb-44f6-a3ef-01e7050d8e3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EarthPower"",
                    ""type"": ""Button"",
                    ""id"": ""95678eb5-3448-455f-b124-f00257589fae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""549e409e-7944-42e9-98d3-0deae24bf0b1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99ed5829-f68e-408b-bd13-4b5cfad5ab51"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ebae0ccb-4af3-4bbf-adfd-12dce8ecc7a4"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""22504a37-035d-48af-972d-3fef4a4597a9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3dbe3edd-1169-461e-8142-c6281c14fb79"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1661eb05-deea-427d-9683-2f8e32ed6b15"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3923f94a-ded5-46ab-a08c-23b389df407c"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4668b875-6864-40ea-98fd-cfbe52eabcaf"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EarthPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""22e8745c-cb90-4f3d-8fb7-981ac2af3dbd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ffd8eef3-2f5b-4b87-b0cf-22c30b129b49"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""472b8a5b-5e0c-40ca-96a0-7fa29c1ca3f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""484627bc-933d-48e3-93b5-c9877a29427f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d826b3fb-c04b-4a1e-8515-c07bcba51599"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_Walking = m_PlayerMap.FindAction("Walking", throwIfNotFound: true);
        m_PlayerMap_Jump = m_PlayerMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMap_Shoot = m_PlayerMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerMap_EarthPower = m_PlayerMap.FindAction("EarthPower", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Move = m_UI.FindAction("Move", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private IPlayerMapActions m_PlayerMapActionsCallbackInterface;
    private readonly InputAction m_PlayerMap_Walking;
    private readonly InputAction m_PlayerMap_Jump;
    private readonly InputAction m_PlayerMap_Shoot;
    private readonly InputAction m_PlayerMap_EarthPower;
    public struct PlayerMapActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_PlayerMap_Walking;
        public InputAction @Jump => m_Wrapper.m_PlayerMap_Jump;
        public InputAction @Shoot => m_Wrapper.m_PlayerMap_Shoot;
        public InputAction @EarthPower => m_Wrapper.m_PlayerMap_EarthPower;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterface != null)
            {
                @Walking.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnWalking;
                @Walking.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnWalking;
                @Walking.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnWalking;
                @Jump.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnJump;
                @Shoot.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnShoot;
                @EarthPower.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnEarthPower;
                @EarthPower.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnEarthPower;
                @EarthPower.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnEarthPower;
            }
            m_Wrapper.m_PlayerMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walking.started += instance.OnWalking;
                @Walking.performed += instance.OnWalking;
                @Walking.canceled += instance.OnWalking;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @EarthPower.started += instance.OnEarthPower;
                @EarthPower.performed += instance.OnEarthPower;
                @EarthPower.canceled += instance.OnEarthPower;
            }
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Move;
    private readonly InputAction m_UI_Submit;
    public struct UIActions
    {
        private @PlayerControls m_Wrapper;
        public UIActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UI_Move;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMove;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerMapActions
    {
        void OnWalking(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnEarthPower(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
}
