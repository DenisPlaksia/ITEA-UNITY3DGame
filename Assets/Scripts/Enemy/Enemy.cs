using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{
    [SerializeField] private Tank tank;
    [SerializeField] private NavMeshAgent meshAgent;

    private void Start()
    {
        tank = GetComponent<Tank>();
        tank.Tower._towerTankData = Test.TowerTankData;
        meshAgent.speed = tank.Tower._towerTankData.GetSpeed();
        meshAgent.SetDestination(new Vector3(0f,1f,0f));
    }
}
