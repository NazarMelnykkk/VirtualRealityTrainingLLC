//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/CORE/Input/CharacterInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CharacterInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CharacterInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CharacterInputActions"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""bded0eec-b573-4b82-aa99-71d98fcdd027"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""02c73ced-e999-49fb-a3c6-05a348edd7e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire1"",
                    ""type"": ""Button"",
                    ""id"": ""d3bc4ba5-b24f-4dc6-8705-ca42dbd9f43d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2"",
                    ""type"": ""Button"",
                    ""id"": ""53096ba9-9b94-43f1-9361-c1a19ab07cf1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""bfbaae67-e552-4e59-946a-1b1ce5d172d8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""54a2939a-286f-49d6-9deb-9f4037cac229"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""09fe3898-08d3-4c67-9934-35735c769e87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CommandsTab"",
                    ""type"": ""Button"",
                    ""id"": ""1bf8792d-0ffc-4c92-80bf-f6ee3b1b5b5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""9c713fea-3381-43fb-be8f-5e17942a020b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""c71676bb-6b91-4106-94af-bdb8fff68808"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AnyKey"",
                    ""type"": ""Button"",
                    ""id"": ""36e4dcc9-c19e-497c-b9d4-698f7834057d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ed162972-b8d3-47d7-9dde-0c57ad5a6b1d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""945b756d-6c79-4130-82c3-b91a037b5329"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2c8558b9-4b03-49d0-be16-a128d5c421d3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d94361fc-1906-44cf-ae4e-9c01dced401f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""af25e0e9-5532-4937-91c7-0f49706ed9f2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""768dd851-1e1d-43a5-97a4-5310049d03ba"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f6dd7c36-a4fc-402a-899d-e9d5259f0ae5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9577a448-c87d-4488-814b-d2855e9dc9b1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6401f569-8bfd-48e4-b635-65388a495e3b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1901fddb-4348-4709-8c4b-6333d87af4d7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""403367da-1cf8-4b90-9393-e06d359fd4f1"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2dec62c6-9302-4d3c-b9e3-da0ce42e1a8f"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CommandsTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d597c71-b39e-47bc-be99-304ce66657f9"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba936b69-0e20-468d-a59c-e6de4218846d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dd954cf-20bf-48d7-aa15-cad9255a73e1"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AnyKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d9c1b5a-faf6-461d-b648-cb025dc07e77"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fff81061-cce1-4cf2-8ccb-8a8624f17904"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5add78ec-9565-41f6-9c2c-4cd5f797b9db"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_MoveDirection = m_Character.FindAction("MoveDirection", throwIfNotFound: true);
        m_Character_Fire1 = m_Character.FindAction("Fire1", throwIfNotFound: true);
        m_Character_Fire2 = m_Character.FindAction("Fire2", throwIfNotFound: true);
        m_Character_Scroll = m_Character.FindAction("Scroll", throwIfNotFound: true);
        m_Character_Interaction = m_Character.FindAction("Interaction", throwIfNotFound: true);
        m_Character_Inventory = m_Character.FindAction("Inventory", throwIfNotFound: true);
        m_Character_CommandsTab = m_Character.FindAction("CommandsTab", throwIfNotFound: true);
        m_Character_Menu = m_Character.FindAction("Menu", throwIfNotFound: true);
        m_Character_Action = m_Character.FindAction("Action", throwIfNotFound: true);
        m_Character_AnyKey = m_Character.FindAction("AnyKey", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_MoveDirection;
    private readonly InputAction m_Character_Fire1;
    private readonly InputAction m_Character_Fire2;
    private readonly InputAction m_Character_Scroll;
    private readonly InputAction m_Character_Interaction;
    private readonly InputAction m_Character_Inventory;
    private readonly InputAction m_Character_CommandsTab;
    private readonly InputAction m_Character_Menu;
    private readonly InputAction m_Character_Action;
    private readonly InputAction m_Character_AnyKey;
    public struct CharacterActions
    {
        private @CharacterInputActions m_Wrapper;
        public CharacterActions(@CharacterInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_Character_MoveDirection;
        public InputAction @Fire1 => m_Wrapper.m_Character_Fire1;
        public InputAction @Fire2 => m_Wrapper.m_Character_Fire2;
        public InputAction @Scroll => m_Wrapper.m_Character_Scroll;
        public InputAction @Interaction => m_Wrapper.m_Character_Interaction;
        public InputAction @Inventory => m_Wrapper.m_Character_Inventory;
        public InputAction @CommandsTab => m_Wrapper.m_Character_CommandsTab;
        public InputAction @Menu => m_Wrapper.m_Character_Menu;
        public InputAction @Action => m_Wrapper.m_Character_Action;
        public InputAction @AnyKey => m_Wrapper.m_Character_AnyKey;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @MoveDirection.started += instance.OnMoveDirection;
            @MoveDirection.performed += instance.OnMoveDirection;
            @MoveDirection.canceled += instance.OnMoveDirection;
            @Fire1.started += instance.OnFire1;
            @Fire1.performed += instance.OnFire1;
            @Fire1.canceled += instance.OnFire1;
            @Fire2.started += instance.OnFire2;
            @Fire2.performed += instance.OnFire2;
            @Fire2.canceled += instance.OnFire2;
            @Scroll.started += instance.OnScroll;
            @Scroll.performed += instance.OnScroll;
            @Scroll.canceled += instance.OnScroll;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
            @Inventory.started += instance.OnInventory;
            @Inventory.performed += instance.OnInventory;
            @Inventory.canceled += instance.OnInventory;
            @CommandsTab.started += instance.OnCommandsTab;
            @CommandsTab.performed += instance.OnCommandsTab;
            @CommandsTab.canceled += instance.OnCommandsTab;
            @Menu.started += instance.OnMenu;
            @Menu.performed += instance.OnMenu;
            @Menu.canceled += instance.OnMenu;
            @Action.started += instance.OnAction;
            @Action.performed += instance.OnAction;
            @Action.canceled += instance.OnAction;
            @AnyKey.started += instance.OnAnyKey;
            @AnyKey.performed += instance.OnAnyKey;
            @AnyKey.canceled += instance.OnAnyKey;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @MoveDirection.started -= instance.OnMoveDirection;
            @MoveDirection.performed -= instance.OnMoveDirection;
            @MoveDirection.canceled -= instance.OnMoveDirection;
            @Fire1.started -= instance.OnFire1;
            @Fire1.performed -= instance.OnFire1;
            @Fire1.canceled -= instance.OnFire1;
            @Fire2.started -= instance.OnFire2;
            @Fire2.performed -= instance.OnFire2;
            @Fire2.canceled -= instance.OnFire2;
            @Scroll.started -= instance.OnScroll;
            @Scroll.performed -= instance.OnScroll;
            @Scroll.canceled -= instance.OnScroll;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
            @Inventory.started -= instance.OnInventory;
            @Inventory.performed -= instance.OnInventory;
            @Inventory.canceled -= instance.OnInventory;
            @CommandsTab.started -= instance.OnCommandsTab;
            @CommandsTab.performed -= instance.OnCommandsTab;
            @CommandsTab.canceled -= instance.OnCommandsTab;
            @Menu.started -= instance.OnMenu;
            @Menu.performed -= instance.OnMenu;
            @Menu.canceled -= instance.OnMenu;
            @Action.started -= instance.OnAction;
            @Action.performed -= instance.OnAction;
            @Action.canceled -= instance.OnAction;
            @AnyKey.started -= instance.OnAnyKey;
            @AnyKey.performed -= instance.OnAnyKey;
            @AnyKey.canceled -= instance.OnAnyKey;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface ICharacterActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
        void OnFire1(InputAction.CallbackContext context);
        void OnFire2(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnCommandsTab(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnAnyKey(InputAction.CallbackContext context);
    }
}