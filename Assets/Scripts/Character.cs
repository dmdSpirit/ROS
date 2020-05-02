using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ROS
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private float movementSpeed = 0.005f;
        [SerializeField] private float pickUpRadius = 3f;
        [SerializeField] private UseIcon useIcon = default;
        [SerializeField] private Transform handsTransform = default;

        private float angleFix = -90f;
        private InputControls inputControls;
        private Vector2 movement;
        private Camera mainCamera;

        private Item carriedItem;

        private void Awake()
        {
            inputControls = new InputControls();
            inputControls.Character.Movement.performed += MovementHandler;
            inputControls.Character.Movement.canceled += MovementHandler;
            inputControls.Character.Use.performed += UsePerformedHandler;
            inputControls.Character.Drop.performed += DropPerformedHandler;
        }

        private void Start()
        {
            mainCamera = Camera.main;
        }

        private void OnEnable()
        {
            inputControls?.Enable();
        }

        private void OnDisable()
        {
            inputControls?.Disable();
        }

        private void Update()
        {
            var mousePosition = inputControls.Character.MousePosition.ReadValue<Vector2>();
            if (carriedItem == null)
            {
                if (TryGetPickableItem(out var item))
                    useIcon.Show(mousePosition, inputControls.Character.Use.bindings[0].path);
                else
                    useIcon.Hide();
            }
            else
                useIcon.Hide();
        }

        private bool TryGetPickableItem(out Item item)
        {
            item = null;
            var mousePosition = inputControls.Character.MousePosition.ReadValue<Vector2>();
            var hit = Physics2D.Raycast(mainCamera.ScreenToWorldPoint(mousePosition), Vector2.zero);
            if (hit.collider == null || (Vector2.Distance(hit.point, transform.position) < pickUpRadius) == false) return false;
            item = hit.collider.GetComponent<Item>();
            return item != null;
        }

        private void FixedUpdate()
        {
            var newPosition = transform.position + (Vector3) movement.normalized * (movementSpeed * Time.fixedDeltaTime);
            Vector3 mousePosition = inputControls.Character.MousePosition.ReadValue<Vector2>();
            var dir = mousePosition - mainCamera.WorldToScreenPoint(newPosition);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + angleFix;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.position = newPosition;
        }

        private void MovementHandler(InputAction.CallbackContext context)
        {
            movement = context.ReadValue<Vector2>();
        }

        private void UsePerformedHandler(InputAction.CallbackContext context)
        {
            if (carriedItem != null) return;
            if (TryGetPickableItem(out var item) == false) return;
            item.PickUp(handsTransform);
            carriedItem = item;
        }

        private void DropPerformedHandler(InputAction.CallbackContext context)
        {
            if (carriedItem == null) return;
            carriedItem.Drop();
            carriedItem = null;
        }
    }
}