using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player = null;
    [SerializeField] private float _difference = 6.5f;
    [SerializeField] private float cameraYPosition = 12;
    [SerializeField] private GameObject _controllerPanel;
    private void Update()
    {
        if(player != null)
        {
            transform.position = new Vector3(0f, cameraYPosition, player.position.z - _difference);
        }
        else
        {
            //new Vector3(0f, 22f, -15f) == new position for camera after player death;
            transform.position = new Vector3(0f, 22f, -15f);
            _controllerPanel.SetActive(false);
        }
    }
}
