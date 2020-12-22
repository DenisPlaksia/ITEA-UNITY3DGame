using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private VariableJoystick _moveJoystick;
    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        _direction = Vector3.forward * _moveJoystick.Vertical;
        Rotate(_moveJoystick.Horizontal);
        Move(_direction);
    }

    private void Rotate(float x)
    {
        transform.Rotate(Vector3.up *  x);
    }

    private void Move(Vector3 direction)
    {        
        transform.Translate(direction * _speed * Time.deltaTime);
        
    }
}
