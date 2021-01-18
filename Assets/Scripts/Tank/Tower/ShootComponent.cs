using UnityEngine;
using System;

public class ShootComponent : MonoBehaviour
{

    [SerializeField] private GameObject _point;
    [SerializeField] private GameObject _bullet;
    public event Action<int> OnAmmoChange;
    private Ray _ray;
    private bool _canAttack;
    private AudioSource _shootAudioSource;
    public int Ammo { get; private set; }
    public float TimeBetweenAtack { get; private set; }
    private void ResetAttack() => _canAttack = false;

    private void Start()
    {
        Ammo = GetComponent<Tower>()._towerTankData.GetAmmo();
        TimeBetweenAtack = GetComponent<Tower>()._towerTankData.GetTimeBetweenAtack();
        _shootAudioSource = GetComponent<AudioSource>();
        OnAmmoChange?.Invoke(Ammo);
    }

    public void AddAmmo(int ammo)
    {
        Ammo += ammo;
        OnAmmoChange?.Invoke(Ammo);
    }

    public void Shoot()
    {
        if (AmmoCheck() && !_canAttack)
        {
            _canAttack = true;
            _ray = new Ray(transform.position, transform.forward);
            var bullet = Instantiate(_bullet, _point.transform.position, _bullet.transform.rotation);
            bullet.GetComponent<Bullet>().Direction = _ray.direction;
            bullet.gameObject.name = transform.parent.name;
            Invoke(nameof(ResetAttack), TimeBetweenAtack);
            Ammo--;
            _shootAudioSource?.Play();
            OnAmmoChange?.Invoke(Ammo);
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
