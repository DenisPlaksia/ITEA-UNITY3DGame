using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _health;
    [SerializeField] private Tank tank;

    private void Start()
    {
        tank.OnHealthChange += Show;
    }

    public void Show(int health)
    {
        _health.SetText(health.ToString());
    }
}
