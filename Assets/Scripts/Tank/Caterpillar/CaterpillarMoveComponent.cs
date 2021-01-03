using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaterpillarMoveComponent : MonoBehaviour
{
    [SerializeField] private VariableJoystick _movementJoystick;
    private Vector3 _direction;
    public float Speed { get; set; } = 1f;
    private void FixedUpdate()
    {
        _direction = Vector3.forward * _movementJoystick.Vertical;
        Moving(_direction);
        Rotation(_movementJoystick.Horizontal);
    }

    public void Moving(Vector3 direction)
    {
        transform.parent.transform.Translate(direction * Speed * Time.deltaTime);
    }

    public void Rotation(float direction)
    {
        transform.parent.transform.Rotate(Vector3.up * direction);
    }
}
