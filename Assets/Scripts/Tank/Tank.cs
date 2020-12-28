using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Caterpillar _caterpillar;
    [SerializeField] private VariableJoystick _movementJoystick;
    private Vector3 _direction;

    private void FixedUpdate()
    {
        _direction = Vector3.forward * _movementJoystick.Vertical;
        _caterpillar.Moving(_direction);
        _caterpillar.Rotation(_movementJoystick.Horizontal);
    }
}
