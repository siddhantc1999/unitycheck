//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Input system/LineController.inputactions
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

public partial class @LineController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LineController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LineController"",
    ""maps"": [
        {
            ""name"": ""LineControl"",
            ""id"": ""ce8dee26-9ca6-4415-a036-abb27e0da1af"",
            ""actions"": [
                {
                    ""name"": ""touchcontrol"",
                    ""type"": ""Button"",
                    ""id"": ""8d3ae3a1-93fb-498a-960e-df1852e5358c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""mousecontrol"",
                    ""type"": ""Button"",
                    ""id"": ""5c8a4ece-117f-455c-a6e5-bce52cbc68f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8398aa79-6b57-4387-ba1c-96c7346aab3b"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""touchcontrol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b3b685-2beb-49f6-9c29-dec1d01db6ca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousecontrol"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LineControl
        m_LineControl = asset.FindActionMap("LineControl", throwIfNotFound: true);
        m_LineControl_touchcontrol = m_LineControl.FindAction("touchcontrol", throwIfNotFound: true);
        m_LineControl_mousecontrol = m_LineControl.FindAction("mousecontrol", throwIfNotFound: true);
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

    // LineControl
    private readonly InputActionMap m_LineControl;
    private List<ILineControlActions> m_LineControlActionsCallbackInterfaces = new List<ILineControlActions>();
    private readonly InputAction m_LineControl_touchcontrol;
    private readonly InputAction m_LineControl_mousecontrol;
    public struct LineControlActions
    {
        private @LineController m_Wrapper;
        public LineControlActions(@LineController wrapper) { m_Wrapper = wrapper; }
        public InputAction @touchcontrol => m_Wrapper.m_LineControl_touchcontrol;
        public InputAction @mousecontrol => m_Wrapper.m_LineControl_mousecontrol;
        public InputActionMap Get() { return m_Wrapper.m_LineControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LineControlActions set) { return set.Get(); }
        public void AddCallbacks(ILineControlActions instance)
        {
            if (instance == null || m_Wrapper.m_LineControlActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_LineControlActionsCallbackInterfaces.Add(instance);
            @touchcontrol.started += instance.OnTouchcontrol;
            @touchcontrol.performed += instance.OnTouchcontrol;
            @touchcontrol.canceled += instance.OnTouchcontrol;
            @mousecontrol.started += instance.OnMousecontrol;
            @mousecontrol.performed += instance.OnMousecontrol;
            @mousecontrol.canceled += instance.OnMousecontrol;
        }

        private void UnregisterCallbacks(ILineControlActions instance)
        {
            @touchcontrol.started -= instance.OnTouchcontrol;
            @touchcontrol.performed -= instance.OnTouchcontrol;
            @touchcontrol.canceled -= instance.OnTouchcontrol;
            @mousecontrol.started -= instance.OnMousecontrol;
            @mousecontrol.performed -= instance.OnMousecontrol;
            @mousecontrol.canceled -= instance.OnMousecontrol;
        }

        public void RemoveCallbacks(ILineControlActions instance)
        {
            if (m_Wrapper.m_LineControlActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ILineControlActions instance)
        {
            foreach (var item in m_Wrapper.m_LineControlActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_LineControlActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public LineControlActions @LineControl => new LineControlActions(this);
    public interface ILineControlActions
    {
        void OnTouchcontrol(InputAction.CallbackContext context);
        void OnMousecontrol(InputAction.CallbackContext context);
    }
}
