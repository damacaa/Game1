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
            ""name"": ""Player1"",
            ""id"": ""c4905410-06f8-493b-b596-8db202752382"",
            ""actions"": [
                {
                    ""name"": ""Boost1"",
                    ""type"": ""Button"",
                    ""id"": ""181ef2a4-2072-4ede-ab9e-37697774d848"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJoystick1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a82ef940-3042-476f-8678-8ccc4c009719"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveKeyboard1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d638f7f2-96b4-4b13-a13a-bfa7c5171d5e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e512437e-3560-4edb-bd72-526739f92f59"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57ad6a3f-ccf3-41d1-a453-2b758086d2a0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb6475ba-6d12-49d1-9217-2c1f84548db6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJoystick1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Direction"",
                    ""id"": ""d957740a-22f4-4018-be50-5ba3930c3998"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""53eb7e22-83d2-406b-a742-a21872be28cd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b747cf29-fd84-4f57-a7d8-db98131bc028"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3e5210ea-f230-43ce-a095-f75163654323"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""65ac19b2-83b6-4528-b875-0881e6965a50"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player2"",
            ""id"": ""33fd84f7-4e10-4394-9c26-e9be2c3e90cd"",
            ""actions"": [
                {
                    ""name"": ""Boost1"",
                    ""type"": ""Button"",
                    ""id"": ""9b488580-8d80-4c39-8d14-68dd50db3d50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveJoystick1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51c01b1b-4f41-44dd-bac2-2dc562f04738"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveKeyboard1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d29facd0-9258-4157-9549-6c2d82a56cb5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7b752354-7952-41b1-a346-3506d204786e"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df4340b1-a78a-4ae2-bf3c-570d9795f797"",
                    ""path"": ""<Keyboard>/rightCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ac44e1c-84e9-4a03-8985-6cbb1c0885ef"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveJoystick1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Direction"",
                    ""id"": ""09b55f6a-dbf1-4e41-87f1-6f4ef79127be"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d73a0fc0-5e1e-49b1-8ff8-eb300038da61"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f1ba6741-736d-4a54-ac63-ae59f18f4dc5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""587b57e9-e580-4635-a29a-9dbfed949924"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""12215470-8e44-4436-b8bb-fbdd1d364b07"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveKeyboard1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Boost1 = m_Player1.FindAction("Boost1", throwIfNotFound: true);
        m_Player1_MoveJoystick1 = m_Player1.FindAction("MoveJoystick1", throwIfNotFound: true);
        m_Player1_MoveKeyboard1 = m_Player1.FindAction("MoveKeyboard1", throwIfNotFound: true);
        // Player2
        m_Player2 = asset.FindActionMap("Player2", throwIfNotFound: true);
        m_Player2_Boost1 = m_Player2.FindAction("Boost1", throwIfNotFound: true);
        m_Player2_MoveJoystick1 = m_Player2.FindAction("MoveJoystick1", throwIfNotFound: true);
        m_Player2_MoveKeyboard1 = m_Player2.FindAction("MoveKeyboard1", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Boost1;
    private readonly InputAction m_Player1_MoveJoystick1;
    private readonly InputAction m_Player1_MoveKeyboard1;
    public struct Player1Actions
    {
        private @PlayerControls m_Wrapper;
        public Player1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Boost1 => m_Wrapper.m_Player1_Boost1;
        public InputAction @MoveJoystick1 => m_Wrapper.m_Player1_MoveJoystick1;
        public InputAction @MoveKeyboard1 => m_Wrapper.m_Player1_MoveKeyboard1;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Boost1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost1;
                @Boost1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost1;
                @Boost1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost1;
                @MoveJoystick1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveJoystick1;
                @MoveJoystick1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveJoystick1;
                @MoveJoystick1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveJoystick1;
                @MoveKeyboard1.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveKeyboard1;
                @MoveKeyboard1.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveKeyboard1;
                @MoveKeyboard1.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMoveKeyboard1;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Boost1.started += instance.OnBoost1;
                @Boost1.performed += instance.OnBoost1;
                @Boost1.canceled += instance.OnBoost1;
                @MoveJoystick1.started += instance.OnMoveJoystick1;
                @MoveJoystick1.performed += instance.OnMoveJoystick1;
                @MoveJoystick1.canceled += instance.OnMoveJoystick1;
                @MoveKeyboard1.started += instance.OnMoveKeyboard1;
                @MoveKeyboard1.performed += instance.OnMoveKeyboard1;
                @MoveKeyboard1.canceled += instance.OnMoveKeyboard1;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);

    // Player2
    private readonly InputActionMap m_Player2;
    private IPlayer2Actions m_Player2ActionsCallbackInterface;
    private readonly InputAction m_Player2_Boost1;
    private readonly InputAction m_Player2_MoveJoystick1;
    private readonly InputAction m_Player2_MoveKeyboard1;
    public struct Player2Actions
    {
        private @PlayerControls m_Wrapper;
        public Player2Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Boost1 => m_Wrapper.m_Player2_Boost1;
        public InputAction @MoveJoystick1 => m_Wrapper.m_Player2_MoveJoystick1;
        public InputAction @MoveKeyboard1 => m_Wrapper.m_Player2_MoveKeyboard1;
        public InputActionMap Get() { return m_Wrapper.m_Player2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2Actions instance)
        {
            if (m_Wrapper.m_Player2ActionsCallbackInterface != null)
            {
                @Boost1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoost1;
                @Boost1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoost1;
                @Boost1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnBoost1;
                @MoveJoystick1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveJoystick1;
                @MoveJoystick1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveJoystick1;
                @MoveJoystick1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveJoystick1;
                @MoveKeyboard1.started -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveKeyboard1;
                @MoveKeyboard1.performed -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveKeyboard1;
                @MoveKeyboard1.canceled -= m_Wrapper.m_Player2ActionsCallbackInterface.OnMoveKeyboard1;
            }
            m_Wrapper.m_Player2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Boost1.started += instance.OnBoost1;
                @Boost1.performed += instance.OnBoost1;
                @Boost1.canceled += instance.OnBoost1;
                @MoveJoystick1.started += instance.OnMoveJoystick1;
                @MoveJoystick1.performed += instance.OnMoveJoystick1;
                @MoveJoystick1.canceled += instance.OnMoveJoystick1;
                @MoveKeyboard1.started += instance.OnMoveKeyboard1;
                @MoveKeyboard1.performed += instance.OnMoveKeyboard1;
                @MoveKeyboard1.canceled += instance.OnMoveKeyboard1;
            }
        }
    }
    public Player2Actions @Player2 => new Player2Actions(this);
    public interface IPlayer1Actions
    {
        void OnBoost1(InputAction.CallbackContext context);
        void OnMoveJoystick1(InputAction.CallbackContext context);
        void OnMoveKeyboard1(InputAction.CallbackContext context);
    }
    public interface IPlayer2Actions
    {
        void OnBoost1(InputAction.CallbackContext context);
        void OnMoveJoystick1(InputAction.CallbackContext context);
        void OnMoveKeyboard1(InputAction.CallbackContext context);
    }
}
