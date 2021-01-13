using UnityEngine;
using TMPro;

public class AmmoShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _ammo;
    private Tank _tank;

    private void Awake()
    {
        _tank = GetComponentInParent<Tank>();
        _tank.Tower.GetComponent<ShootComponent>().OnAmmoChange += Show;
        Debug.Log(_tank);
    }

    public void Show(int ammo)
    {
        _ammo.SetText(ammo.ToString());
    }
}
