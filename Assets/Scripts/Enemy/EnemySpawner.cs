using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;

    private void Awake()
    {
        Spawn();
    }
    private void Spawn()
    {
        for (int i = -4; i < 4; i += 2)
        {
            Instantiate(enemy, new Vector3(i, 1f, transform.position.z), transform.rotation);
        }
    }
}
