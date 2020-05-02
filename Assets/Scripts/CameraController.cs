using System;
using UnityEngine;

namespace ROS
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Character character = default;
        [SerializeField] private float speed = 1f;
        [SerializeField] private float minimalDistance = 1f;

        private void FixedUpdate()
        {
            Vector3 characterPosition = character.transform.position;
            Vector3 cameraPosition = transform.position;
            characterPosition.z = cameraPosition.z;
            var distance = Vector3.Distance(characterPosition, cameraPosition);
            if (distance > minimalDistance)
            {
                transform.position = Vector3.MoveTowards(cameraPosition, characterPosition, speed * Time.deltaTime);
            }
        }
    }
}