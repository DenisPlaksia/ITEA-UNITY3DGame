using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    [SerializeField] private float _difference = 6.5f;
    [SerializeField] private float cameraYPosition = 12;

    private void Update()
    {
        transform.position = new Vector3(0f, cameraYPosition, player.position.z - _difference);
    }
}
