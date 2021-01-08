using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    [SerializeField] private Tank tank;
    [SerializeField] private PlayerData player;
    [SerializeField] private NavMeshAgent meshAgent;
    [SerializeField] private float radius;
    private float distance = 0f;
    private ShootComponent shootComponent;

    private void Start()
    {
        player = FindObjectOfType<PlayerData>();
        tank = GetComponent<Tank>();
        tank.Tower._towerTankData = Test.TowerTankData;
        tank.Tower.TryGetComponent<ShootComponent>(out shootComponent);
        meshAgent.speed = tank.Tower._towerTankData.GetSpeed();
        meshAgent.SetDestination(new Vector3(0f,1f,0f));
    }

    private void Update()
    {
        SetDistance();
        if (distance < radius)
        {
            shootComponent.Shoot();
        }
    }

    private void SetDistance() => distance = Vector3.Distance(player.transform.position, transform.position);
}
