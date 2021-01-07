using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _health;
    private Tank tank;

    private void Start()
    {
        tank = GetComponentInParent<Tank>();
        tank.OnHealthChange += Show;
        Debug.Log(tank);
    }

    public void Show(int health)
    {
        _health.SetText(health.ToString());
    }
}
