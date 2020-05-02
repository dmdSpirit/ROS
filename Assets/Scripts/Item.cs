using UnityEngine;

namespace ROS
{
    public class Item : MonoBehaviour
    {
        private Collider2D collider;
        private Transform previousParentTransform;

        private void Awake()
        {
            collider = GetComponent<Collider2D>();
            if (collider == null)
                Debug.LogError("Collider is not found.");
        }

        public void PickUp(Transform characterHands)
        {
            previousParentTransform = transform.parent;
            collider.enabled = false;
            transform.SetParent(characterHands, false);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }

        public void Drop()
        {
            transform.SetParent(previousParentTransform);
            collider.enabled = true;
        }
    }
}