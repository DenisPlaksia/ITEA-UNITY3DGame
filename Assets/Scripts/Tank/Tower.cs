using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private VariableJoystick _towerMovementJoystick;
    [SerializeField] private TowerTankData _towerTankData;
    [SerializeField] private GameObject _point;
    private Vector3 _direction;

    private void Update()
    {
        _direction = new Vector3(0f,_towerMovementJoystick.Direction.x + _towerMovementJoystick.Direction.y, 0f);
        Rotation(_direction);
    }

    private void Shoot()
    {
        if(AmmoCheck())
        {
            Instantiate()
        }
    }

    private bool AmmoCheck()
    {
        if(_towerTankData.GetAmmo() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Rotation(Vector3 direction)
    {
        transform.Rotate(direction * _towerTankData.GetSpeed());
    }
}
