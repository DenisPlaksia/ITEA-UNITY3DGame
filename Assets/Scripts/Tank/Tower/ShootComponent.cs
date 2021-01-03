using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootComponent : MonoBehaviour
{

    [SerializeField] private GameObject _point;
    [SerializeField] private GameObject _bullet;

    private Ray _ray;
    private bool _canAttack;

    public int Ammo { get; set; }
    public float TimeBetweenAtack { get; set; }
    private void ResetAttack() => _canAttack = false;

    public void Shoot()
    {
        if (AmmoCheck() && !_canAttack)
        {
            _canAttack = true;
            _ray = new Ray(transform.position, transform.forward);
            var bullet = Instantiate(_bullet, _point.transform.position, _bullet.transform.rotation);
            bullet.GetComponent<Bullet>().Direction = _ray.direction;
            Invoke(nameof(ResetAttack), TimeBetweenAtack);
            Ammo--;
        }
    }

    private bool AmmoCheck()
    {
        if (Ammo > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
