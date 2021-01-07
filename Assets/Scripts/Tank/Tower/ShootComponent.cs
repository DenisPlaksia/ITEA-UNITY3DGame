using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootComponent : MonoBehaviour
{

    [SerializeField] private GameObject _point;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Button _shootButton;

    private Ray _ray;
    private bool _canAttack;

    public int Ammo { get; private set; }
    public float TimeBetweenAtack { get; private set; }
    private void ResetAttack() => _canAttack = false;

    private void Start()
    {
        Ammo = GetComponent<Tower>()._towerTankData.GetAmmo();
        TimeBetweenAtack = GetComponent<Tower>()._towerTankData.GetTimeBetweenAtack();
        _shootButton.onClick.AddListener(Shoot);
    }
    public void Shoot()
    {
        if (AmmoCheck() && !_canAttack)
        {
            _canAttack = true;
            _ray = new Ray(transform.position, transform.forward);
            var bullet = Instantiate(_bullet, _point.transform.position, _bullet.transform.rotation);
            bullet.GetComponent<Bullet>().Direction = _ray.direction;
            bullet.name = gameObject.GetComponentInParent<PlayerData>().GetName();
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
