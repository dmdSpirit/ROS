// GENERATED AUTOMATICALLY FROM 'Assets/InputControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ROS
{
    public class @InputControlls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControlls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControlls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""42acbdcd-3e41-4bb2-bbc6-18577a4d0776"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1dc372b-ba7d-4219-8a25-849c5dc7914a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3aaef630-fe17-48aa-a3dd-80dff4a12ecd"",
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
                    ""id"": ""64c633fe-c385-4e79-a318-2fb516abe461"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Game"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""293f0fb3-3237-4524-9158-03cedb1f56e9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Game"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a09cc154-9d83-4da9-a95f-3b95686970cb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Game"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""80435336-0ee3-4b4f-ab8e-c5f8057a3da3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Game"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Game"",
            ""bindingGroup"": ""Game"",
            ""devices"": []
        }
    ]
}");
            // Character
            m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
            m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
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

        // Character
        private readonly InputActionMap m_Character;
        private ICharacterActions m_CharacterActionsCallbackInterface;
        private readonly InputAction m_Character_Movement;
        public struct CharacterActions
        {
            private @InputControlls m_Wrapper;
            public CharacterActions(@InputControlls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Character_Movement;
            public InputActionMap Get() { return m_Wrapper.m_Character; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
            public void SetCallbacks(ICharacterActions instance)
            {
                if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                }
                m_Wrapper.m_CharacterActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                }
            }
        }
        public CharacterActions @Character => new CharacterActions(this);
        private int m_GameSchemeIndex = -1;
        public InputControlScheme GameScheme
        {
            get
            {
                if (m_GameSchemeIndex == -1) m_GameSchemeIndex = asset.FindControlSchemeIndex("Game");
                return asset.controlSchemes[m_GameSchemeIndex];
            }
        }
        public interface ICharacterActions
        {
            void OnMovement(InputAction.CallbackContext context);
        }
    }
}
