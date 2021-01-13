using UnityEngine;
using UnityEngine.AI;


public class UnitBehavior : MonoBehaviour
{
    [SerializeField] private Tank tank;
    [SerializeField] private NavMeshAgent meshAgent;
    [SerializeField] private float radius;

    [SerializeField] private State StartState;
    [SerializeField] private State AmmoFindState;
    [SerializeField] private State EnemyShootingState;
    [SerializeField] private State WalkToWinZoneState;
    [SerializeField] private State HealthFindState;

    [Header("Actual state")]
    [SerializeField] private State currentState;
    private ShootComponent shootComponent;

    public GameObject winZona;
    public float ShootAngle;
    public string tagForEnemy;
    public string winZonaTag;
    public Tank Tank
    {
        get
        {
            return tank;
        }
    }
    public NavMeshAgent MeshAgent
    {
        get
        {
            return meshAgent;
        }
    }
    public ShootComponent ShootComponent
    {
        get
        {
            return shootComponent;
        }
    }
    private void Start()
    {
        SetAllComponents();
        SetState(StartState);
        meshAgent.speed = tank.Tower._towerTankData.GetSpeed();
    }

    private void SetAllComponents()
    {
        tank = GetComponent<Tank>();
        winZona = GameObject.FindGameObjectWithTag(winZonaTag);
        tank.Tower._towerTankData = Test.TowerTankData;
        tank.Tower.TryGetComponent<ShootComponent>(out shootComponent);
        meshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (!currentState.IsFinished)
        {
            currentState.Run();
        }
        else if (shootComponent.Ammo <= 2)
        {
            
            SetState(AmmoFindState);
        }
        else if (Tank.GetHealth() <= 50)
        {
            SetState(HealthFindState);
        }
        else if (Tank.GetHealth() > 60 && shootComponent.Ammo >= 3)
        {
            SetState(WalkToWinZoneState);
        }
        else
        {
            SetState(WalkToWinZoneState);
        }

    }

    public void SetState(State state)
    {
        
        currentState = Instantiate(state);
        currentState.unit = this;
        currentState.Init();
    }

    public void StopState()
    {
        currentState.Stop();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == tagForEnemy)
        {
            currentState.Stop();
            SetState(EnemyShootingState);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == tagForEnemy)
        {
            var targetPosition = other.transform.position;
            targetPosition.y = transform.position.y;
            tank.Tower.transform.LookAt(targetPosition);
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == tagForEnemy)
        {
            currentState.Stop();
            SetState(WalkToWinZoneState);
        }
    }

}
