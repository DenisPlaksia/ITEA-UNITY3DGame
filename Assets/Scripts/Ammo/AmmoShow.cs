using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _ammo;
    private Tank tank;

    private void Start()
    {
        tank = GetComponentInParent<Tank>();
        tank.Tower.GetComponent<ShootComponent>().OnAmmoChange += Show;
        Debug.Log(tank);
    }

    public void Show(int ammo)
    {
        _ammo.SetText(ammo.ToString());
    }
}
