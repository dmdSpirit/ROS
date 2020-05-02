using TMPro;
using UnityEngine;

namespace ROS
{
    public class UseIcon : MonoBehaviour
    {
        [SerializeField] private Vector2 iconOffset = default;

        private TextMeshProUGUI hotkeyLabel = default;

        private void Awake()
        {
            hotkeyLabel = GetComponent<TextMeshProUGUI>();
        }

        public void Show(Vector2 mousePosition, string path)
        {
            var text = path.Substring(path.IndexOf('/')+1).Trim().ToUpper();
            if (gameObject.activeInHierarchy == false) gameObject.SetActive(true);
            hotkeyLabel.SetText($"[ {text} ]");
            transform.position = mousePosition + iconOffset;
        }

        public void Hide()
        {
            if (gameObject.activeInHierarchy)
                gameObject.SetActive(false);
        }
    }
}