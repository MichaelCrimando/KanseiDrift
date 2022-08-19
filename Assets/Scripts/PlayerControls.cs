// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActionControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActionControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""238552cd-c386-4602-8c0c-66736d2c6303"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0ce42299-495c-45d9-abef-78f9dfef94e2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake Right"",
                    ""type"": ""Value"",
                    ""id"": ""4fee4554-c802-4b14-9194-05a25d77a411"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake Left"",
                    ""type"": ""Value"",
                    ""id"": ""421df0af-f220-4c7b-add0-969f2c7ee30a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Sideways (Gamepad)"",
                    ""id"": ""2247cf6d-d265-46c3-93bd-e9b1facab03e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f7010293-830b-4d87-a55a-7452d041ff9b"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d037d409-4fe5-4a11-8c54-08fa08b02b0c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Sideways"",
                    ""id"": ""d550c397-f09e-487a-82fd-0364868c28ed"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5f7d1a7b-f483-4c67-98d3-a98394fdf2c9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4b383b05-49f2-4407-8195-97698b0e7293"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4b45d172-5d3b-4854-b20f-e3fe76cae37f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c78601f-7c31-40c9-aa3d-3cb359b6b3bc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""884fa768-6285-48b0-b6f4-3ab9eb6b9ddc"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Brake Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55732d2b-b151-4b18-9503-f4501a70490a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Brake Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DelayTest"",
            ""id"": ""193e1ea8-7584-4ddd-97fd-67123bd274df"",
            ""actions"": [
                {
                    ""name"": ""LiterallyAnyButton"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2eda48b0-42e3-4a33-b839-a7032cc951d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Value"",
                    ""id"": ""c7f77348-6f3a-456d-94d6-4d56f6acc835"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9d75972-9465-482e-975b-dfdbb6331bf2"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DelayTest;Gamepad"",
                    ""action"": ""LiterallyAnyButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7424707-66fe-47f0-9643-09da83e80488"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""LiterallyAnyButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13e4ef31-7a9b-410b-bca9-d2a6eb8611dd"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""LiterallyAnyButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04935ec8-841d-46cc-9294-827ab77f72b2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DelayTest;Gamepad"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83e8d165-280e-409f-969b-fe3c28d87387"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07f66e09-ffbd-48ed-a67f-30464a6fd362"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3aa9fa0c-54ea-4e25-8a70-1ee439b7ea4c"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93bec5d0-c76f-4d50-b09d-f00e83457781"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""f80170f3-7f4a-456a-a17a-d3c85b437905"",
            ""actions"": [
                {
                    ""name"": ""Play"",
                    ""type"": ""Value"",
                    ""id"": ""c1f2438a-5d1e-400a-9eae-c164af8cea76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Terms"",
                    ""type"": ""Button"",
                    ""id"": ""f5efa6fa-915b-4bb7-b962-a223d122f75a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Delay Test"",
                    ""type"": ""Button"",
                    ""id"": ""2daf3489-db07-48f4-ac89-10662fbb305f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2cc00db2-6172-4dce-8541-8dad4fe1b3fd"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Terms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a822041b-3b46-4d78-a81a-eded1c277cd9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Terms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79f484e0-a451-4088-b1c4-eb38269c08a5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DelayTest;Gamepad"",
                    ""action"": ""Terms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6903e659-7b01-4321-9732-5d709bc8d458"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Delay Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c7654cf-af8f-4f2b-895d-6995f6455258"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Delay Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""165015bc-b9f8-4692-a392-3c84707e2ad1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Delay Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dccdb79d-5738-47fd-b46e-067284bcb986"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c30981c8-48ed-435b-8b22-16f1f3c92bca"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8456f93a-7de4-4589-941a-7d51b1c7e1f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad;DelayTest"",
                    ""action"": ""Play"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<AndroidGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""DelayTest"",
            ""bindingGroup"": ""DelayTest"",
            ""devices"": [
                {
                    ""devicePath"": ""<AndroidGamepadXboxController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Move = m_Driving.FindAction("Move", throwIfNotFound: true);
        m_Driving_BrakeRight = m_Driving.FindAction("Brake Right", throwIfNotFound: true);
        m_Driving_BrakeLeft = m_Driving.FindAction("Brake Left", throwIfNotFound: true);
        // DelayTest
        m_DelayTest = asset.FindActionMap("DelayTest", throwIfNotFound: true);
        m_DelayTest_LiterallyAnyButton = m_DelayTest.FindAction("LiterallyAnyButton", throwIfNotFound: true);
        m_DelayTest_Back = m_DelayTest.FindAction("Back", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Play = m_Menu.FindAction("Play", throwIfNotFound: true);
        m_Menu_Terms = m_Menu.FindAction("Terms", throwIfNotFound: true);
        m_Menu_DelayTest = m_Menu.FindAction("Delay Test", throwIfNotFound: true);
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

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Move;
    private readonly InputAction m_Driving_BrakeRight;
    private readonly InputAction m_Driving_BrakeLeft;
    public struct DrivingActions
    {
        private @PlayerActionControls m_Wrapper;
        public DrivingActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Driving_Move;
        public InputAction @BrakeRight => m_Wrapper.m_Driving_BrakeRight;
        public InputAction @BrakeLeft => m_Wrapper.m_Driving_BrakeLeft;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnMove;
                @BrakeRight.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeRight;
                @BrakeRight.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeRight;
                @BrakeRight.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeRight;
                @BrakeLeft.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeLeft;
                @BrakeLeft.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeLeft;
                @BrakeLeft.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrakeLeft;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @BrakeRight.started += instance.OnBrakeRight;
                @BrakeRight.performed += instance.OnBrakeRight;
                @BrakeRight.canceled += instance.OnBrakeRight;
                @BrakeLeft.started += instance.OnBrakeLeft;
                @BrakeLeft.performed += instance.OnBrakeLeft;
                @BrakeLeft.canceled += instance.OnBrakeLeft;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // DelayTest
    private readonly InputActionMap m_DelayTest;
    private IDelayTestActions m_DelayTestActionsCallbackInterface;
    private readonly InputAction m_DelayTest_LiterallyAnyButton;
    private readonly InputAction m_DelayTest_Back;
    public struct DelayTestActions
    {
        private @PlayerActionControls m_Wrapper;
        public DelayTestActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LiterallyAnyButton => m_Wrapper.m_DelayTest_LiterallyAnyButton;
        public InputAction @Back => m_Wrapper.m_DelayTest_Back;
        public InputActionMap Get() { return m_Wrapper.m_DelayTest; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DelayTestActions set) { return set.Get(); }
        public void SetCallbacks(IDelayTestActions instance)
        {
            if (m_Wrapper.m_DelayTestActionsCallbackInterface != null)
            {
                @LiterallyAnyButton.started -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnLiterallyAnyButton;
                @LiterallyAnyButton.performed -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnLiterallyAnyButton;
                @LiterallyAnyButton.canceled -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnLiterallyAnyButton;
                @Back.started -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_DelayTestActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_DelayTestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LiterallyAnyButton.started += instance.OnLiterallyAnyButton;
                @LiterallyAnyButton.performed += instance.OnLiterallyAnyButton;
                @LiterallyAnyButton.canceled += instance.OnLiterallyAnyButton;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public DelayTestActions @DelayTest => new DelayTestActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Play;
    private readonly InputAction m_Menu_Terms;
    private readonly InputAction m_Menu_DelayTest;
    public struct MenuActions
    {
        private @PlayerActionControls m_Wrapper;
        public MenuActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Play => m_Wrapper.m_Menu_Play;
        public InputAction @Terms => m_Wrapper.m_Menu_Terms;
        public InputAction @DelayTest => m_Wrapper.m_Menu_DelayTest;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Play.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Play.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPlay;
                @Terms.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnTerms;
                @Terms.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnTerms;
                @Terms.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnTerms;
                @DelayTest.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnDelayTest;
                @DelayTest.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnDelayTest;
                @DelayTest.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnDelayTest;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Play.started += instance.OnPlay;
                @Play.performed += instance.OnPlay;
                @Play.canceled += instance.OnPlay;
                @Terms.started += instance.OnTerms;
                @Terms.performed += instance.OnTerms;
                @Terms.canceled += instance.OnTerms;
                @DelayTest.started += instance.OnDelayTest;
                @DelayTest.performed += instance.OnDelayTest;
                @DelayTest.canceled += instance.OnDelayTest;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_DelayTestSchemeIndex = -1;
    public InputControlScheme DelayTestScheme
    {
        get
        {
            if (m_DelayTestSchemeIndex == -1) m_DelayTestSchemeIndex = asset.FindControlSchemeIndex("DelayTest");
            return asset.controlSchemes[m_DelayTestSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnBrakeRight(InputAction.CallbackContext context);
        void OnBrakeLeft(InputAction.CallbackContext context);
    }
    public interface IDelayTestActions
    {
        void OnLiterallyAnyButton(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnPlay(InputAction.CallbackContext context);
        void OnTerms(InputAction.CallbackContext context);
        void OnDelayTest(InputAction.CallbackContext context);
    }
}