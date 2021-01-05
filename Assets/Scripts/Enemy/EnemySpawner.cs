using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private void Start()
    {
        Spawn();
    }
    private void Spawn()
    {
        for (int i = -4; i < 4; i += 2)
        {
            Instantiate(enemy, new Vector3(i,transform.position.y,transform.position.z), transform.rotation);
        }
    }
}
