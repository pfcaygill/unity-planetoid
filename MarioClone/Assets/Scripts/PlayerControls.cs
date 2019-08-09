// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerControls : IInputActionCollection
{
    private InputActionAsset asset;
    public PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""349cdeb3-90b7-439f-94e1-7dd97068363d"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Button"",
                    ""id"": ""383c3674-3ea3-47f2-ad9c-fe84e5289a7e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""61ee4df9-f672-4313-acf5-66d77736e739"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""spin_clock"",
                    ""type"": ""Button"",
                    ""id"": ""785b8d34-1657-41a3-b42b-3f29bdc03586"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""spin_anti"",
                    ""type"": ""Button"",
                    ""id"": ""418ee872-3baf-4f0a-a823-14bae6471e55"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move_com"",
                    ""type"": ""Button"",
                    ""id"": ""256fd667-5dcd-4916-8a53-03e2b5e336ac"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b153fad1-3da6-4fd9-8526-3ca4e9ceae16"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f3c5a2-0f7b-4707-81a8-a7e179ace87b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c73ed9c2-852a-421d-89bb-688365309630"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""spin_clock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9905451-10a7-446e-917c-bb9ccd98742f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""spin_anti"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18089e6c-5841-46e4-9be4-48c2976eb0c6"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move_com"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.GetActionMap("gameplay");
        m_gameplay_move = m_gameplay.GetAction("move");
        m_gameplay_jump = m_gameplay.GetAction("jump");
        m_gameplay_spin_clock = m_gameplay.GetAction("spin_clock");
        m_gameplay_spin_anti = m_gameplay.GetAction("spin_anti");
        m_gameplay_move_com = m_gameplay.GetAction("move_com");
    }

    ~PlayerControls()
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_move;
    private readonly InputAction m_gameplay_jump;
    private readonly InputAction m_gameplay_spin_clock;
    private readonly InputAction m_gameplay_spin_anti;
    private readonly InputAction m_gameplay_move_com;
    public struct GameplayActions
    {
        private PlayerControls m_Wrapper;
        public GameplayActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_gameplay_move;
        public InputAction @jump => m_Wrapper.m_gameplay_jump;
        public InputAction @spin_clock => m_Wrapper.m_gameplay_spin_clock;
        public InputAction @spin_anti => m_Wrapper.m_gameplay_spin_anti;
        public InputAction @move_com => m_Wrapper.m_gameplay_move_com;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                spin_clock.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_clock;
                spin_clock.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_clock;
                spin_clock.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_clock;
                spin_anti.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_anti;
                spin_anti.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_anti;
                spin_anti.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSpin_anti;
                move_com.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_com;
                move_com.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_com;
                move_com.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove_com;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                move.started += instance.OnMove;
                move.performed += instance.OnMove;
                move.canceled += instance.OnMove;
                jump.started += instance.OnJump;
                jump.performed += instance.OnJump;
                jump.canceled += instance.OnJump;
                spin_clock.started += instance.OnSpin_clock;
                spin_clock.performed += instance.OnSpin_clock;
                spin_clock.canceled += instance.OnSpin_clock;
                spin_anti.started += instance.OnSpin_anti;
                spin_anti.performed += instance.OnSpin_anti;
                spin_anti.canceled += instance.OnSpin_anti;
                move_com.started += instance.OnMove_com;
                move_com.performed += instance.OnMove_com;
                move_com.canceled += instance.OnMove_com;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSpin_clock(InputAction.CallbackContext context);
        void OnSpin_anti(InputAction.CallbackContext context);
        void OnMove_com(InputAction.CallbackContext context);
    }
}
