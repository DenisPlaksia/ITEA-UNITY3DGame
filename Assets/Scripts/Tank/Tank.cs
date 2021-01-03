using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tank : MonoBehaviour, IDamage
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Caterpillar _caterpillar;
    [SerializeField] private int health = 100;
   
    public Tower Tower { get => _tower; }
    public Caterpillar Caterpillar { get => _caterpillar; }


    public event Action<int> OnHealthChange;

    public void GetDamage(int damage)
    {
        health -= damage;
        OnHealthChange?.Invoke(health);
        if (health <= 0)
        {
            Death();
        }

    }

    private void Death()
    {
        Destroy(gameObject);
    }


}
