using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Tank : MonoBehaviour, IDamage
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Caterpillar _caterpillar;
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject _deathParticle;
    public Tower Tower { get => _tower; }
    public Caterpillar Caterpillar { get => _caterpillar; }


    public event Action<int> OnHealthChange;
    public event Action<Tank,string> OnDeath;


    public void GetDamage(int damage,string name)
    {
        health -= damage;
        string _name = name;
        OnHealthChange?.Invoke(health);
        if (health <= 0)
        {
            Death(_name);
        }

    }

    public void AddHealth(int value)
    {
        health += value;
        OnHealthChange?.Invoke(health);
    }

    public int GetHealth()
    {
        return health;
    }

    private void Death(string name)
    {
        OnDeath?.Invoke(this,name);
        if(name == PlayerData.Name)
        {
            PlayerResults.kill++;
        }
        Instantiate(_deathParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<IInteractable>() != null)
        {
            collision.gameObject.GetComponent<IInteractable>().Interact(this);
        }
    }

}
