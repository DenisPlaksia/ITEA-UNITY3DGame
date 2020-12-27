using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private VariableJoystick _towerMovementJoystick;
    [SerializeField] private TowerTankData _towerTankData;
    [SerializeField] private GameObject _point;
    [SerializeField] private GameObject _bullet;

    private int _ammo = 0;
    private Ray _ray;
    private Vector3 _direction;
    private bool _canAttack;

    private void Update()
    {
        _direction = new Vector3(0f,_towerMovementJoystick.Direction.x + _towerMovementJoystick.Direction.y, 0f);
        if(Input.GetKeyDown(KeyCode.W))
        {
            
            Shoot();
        }
        Rotation(_direction);
    }

    private void ResetAttack() => _canAttack = false;

    private void Start()
    {
        _ammo = _towerTankData.GetAmmo();
    }
    private void SetTowerTankData(TowerTankData towerTankData)
    {
        _towerTankData = towerTankData;
    }
    private void Shoot()
    {
        if(AmmoCheck() && !_canAttack)
        {
            _canAttack = true;
            _ray = new Ray(transform.position, transform.forward);
            var bullet = Instantiate(_bullet, _point.transform.position, _bullet.transform.rotation);
            bullet.GetComponent<Bullet>().Direction = _ray.direction;
            Invoke(nameof(ResetAttack), _towerTankData.GetTimeBetweenAtack());
            _ammo--;
        }
    }

    private bool AmmoCheck()
    {
        if(_ammo > 0)
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
