using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMoveComponent : MonoBehaviour
{
    [SerializeField] private VariableJoystick _towerMovementJoystick;

    private Vector3 _direction;

    public float Speed { get; set; }
    private void Update()
    {
        _direction = new Vector3(0f, _towerMovementJoystick.Direction.x + _towerMovementJoystick.Direction.y, 0f);
        Rotation(_direction);
    }
    private void Rotation(Vector3 direction)
    {
        transform.Rotate(direction * Speed);
    }
}
