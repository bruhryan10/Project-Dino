//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player.inputactions
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

public partial class @Player: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d6c5912f-593c-4812-9291-59e37a2ede8d"",
            ""actions"": [
                {
                    ""name"": ""HE"",
                    ""type"": ""Button"",
                    ""id"": ""fc71f074-c931-464a-a7c6-df6c999b3542"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Button"",
                    ""id"": ""ff3f4536-6f48-4089-a466-badf414c84a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""715f7e7a-9de9-46a6-b5b6-8e52c99656a2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""HE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b387f4c5-10fd-4009-bb75-77f4802dcba7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""HE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75d5fa57-d7de-4fc7-b5c9-d69f871d27bc"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""HE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""leftrightAD"",
                    ""id"": ""627651e6-81ba-4597-8202-f77ad5c1bdb1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a6f9584-e406-4d93-a90c-a22a57507adc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b412d08d-c0b6-43f5-b051-5714d08c23dc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""leftrightkey"",
                    ""id"": ""b1e24ea0-7f98-4724-b16b-482d8ccb6203"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3d4315db-0c55-40d2-a17f-eb22aac89299"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c61570b5-2c0d-400d-92ea-97603c442f30"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""kbm"",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""kbm"",
            ""bindingGroup"": ""kbm"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HE = m_Movement.FindAction("HE", throwIfNotFound: true);
        m_Movement_move = m_Movement.FindAction("move", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_HE;
    private readonly InputAction m_Movement_move;
    public struct MovementActions
    {
        private @Player m_Wrapper;
        public MovementActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @HE => m_Wrapper.m_Movement_HE;
        public InputAction @move => m_Wrapper.m_Movement_move;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @HE.started += instance.OnHE;
            @HE.performed += instance.OnHE;
            @HE.canceled += instance.OnHE;
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @HE.started -= instance.OnHE;
            @HE.performed -= instance.OnHE;
            @HE.canceled -= instance.OnHE;
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    private int m_kbmSchemeIndex = -1;
    public InputControlScheme kbmScheme
    {
        get
        {
            if (m_kbmSchemeIndex == -1) m_kbmSchemeIndex = asset.FindControlSchemeIndex("kbm");
            return asset.controlSchemes[m_kbmSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnHE(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
