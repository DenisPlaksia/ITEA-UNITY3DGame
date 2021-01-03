using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tank : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Caterpillar _caterpillar;
   
    public Tower Tower { get => _tower; }
    public Caterpillar Caterpillar { get => _caterpillar; }

    [SerializeField] private float health;
    private Action<float> _healthEvent;
    public event Action<float> HealthEvent
    {
        add
        {
            _healthEvent += value;//gameObject.GetComponentInChildren<HealthShow>().Show(health);
        }
        remove
        {

        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            _healthEvent?.Invoke(health);
        }
    }
}
