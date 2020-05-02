// GENERATED AUTOMATICALLY FROM 'Assets/InputControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ROS
{
    public class @InputControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControls()
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
                    ""type"": ""Value"",
                    ""id"": ""d1dc372b-ba7d-4219-8a25-849c5dc7914a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""0dbd9295-0e48-481a-a585-6b8d4191ac76"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use"",
                    ""type"": ""Button"",
                    ""id"": ""0a8c6f75-a0fd-4181-9696-06d7388e3ca4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drop"",
                    ""type"": ""Button"",
                    ""id"": ""c209a882-695b-46b6-82f1-c5485f36fc2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""45701671-0ac0-471e-bf53-9a08064044f8"",
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
                    ""id"": ""9ed44c5d-a5c7-4ce0-ad40-0cd1be3626c9"",
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
                    ""id"": ""37744250-e87d-432c-ba18-4cea2027cb69"",
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
                    ""id"": ""a9696d60-bfd7-4406-982d-fd69fba1637e"",
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
                    ""id"": ""5184c66c-c1ca-4354-931a-7e30bb51d865"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""501d5ebd-cb94-4272-aaf1-60feabb58513"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6da7f5d3-6c15-481e-bd10-c10d97b436ab"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aa66eff-8dfc-49ca-bb79-f1d028b410e9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drop"",
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
            m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
            m_Character_MousePosition = m_Character.FindAction("MousePosition", throwIfNotFound: true);
            m_Character_Use = m_Character.FindAction("Use", throwIfNotFound: true);
            m_Character_Drop = m_Character.FindAction("Drop", throwIfNotFound: true);
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
        private readonly InputAction m_Character_MousePosition;
        private readonly InputAction m_Character_Use;
        private readonly InputAction m_Character_Drop;
        public struct CharacterActions
        {
            private @InputControls m_Wrapper;
            public CharacterActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Character_Movement;
            public InputAction @MousePosition => m_Wrapper.m_Character_MousePosition;
            public InputAction @Use => m_Wrapper.m_Character_Use;
            public InputAction @Drop => m_Wrapper.m_Character_Drop;
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
                    @MousePosition.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMousePosition;
                    @MousePosition.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMousePosition;
                    @MousePosition.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMousePosition;
                    @Use.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUse;
                    @Use.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUse;
                    @Use.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnUse;
                    @Drop.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDrop;
                    @Drop.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDrop;
                    @Drop.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnDrop;
                }
                m_Wrapper.m_CharacterActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @MousePosition.started += instance.OnMousePosition;
                    @MousePosition.performed += instance.OnMousePosition;
                    @MousePosition.canceled += instance.OnMousePosition;
                    @Use.started += instance.OnUse;
                    @Use.performed += instance.OnUse;
                    @Use.canceled += instance.OnUse;
                    @Drop.started += instance.OnDrop;
                    @Drop.performed += instance.OnDrop;
                    @Drop.canceled += instance.OnDrop;
                }
            }
        }
        public CharacterActions @Character => new CharacterActions(this);
        public interface ICharacterActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnMousePosition(InputAction.CallbackContext context);
            void OnUse(InputAction.CallbackContext context);
            void OnDrop(InputAction.CallbackContext context);
        }
    }
}
