using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour, IInteractable
{
    public void Interact(Tank tank)
    {
        tank.Tower.GetComponent<ShootComponent>().AddAmmo(5);
        Destroy(gameObject);
    }
}
