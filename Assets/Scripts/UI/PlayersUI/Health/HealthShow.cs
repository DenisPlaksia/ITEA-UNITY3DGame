using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _health;


    private void Start()
    {
        
    }

    public void Show(float health)
    {
        _health.SetText(health.ToString());
    }
}
