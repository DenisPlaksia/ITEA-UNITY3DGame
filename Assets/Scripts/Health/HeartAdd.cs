using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartAdd : MonoBehaviour, IInteractable
{
    public void Interact(Tank tank)
    {
        int rand = Random.Range(50, 81);
        tank.AddHealth(rand);
        Destroy(gameObject);
    }
}
