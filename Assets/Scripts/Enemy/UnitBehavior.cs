using UnityEngine;
using UnityEngine.AI;


public class UnitBehavior : MonoBehaviour
{
    [SerializeField] private Tank tank;
    [SerializeField] private PlayerData player;
    [SerializeField] private NavMeshAgent meshAgent;
    public LayerMask _whatIsEnemy;
    private Collider _collider;
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

    public Collider Collider
    {
        get
        {
            return _collider;
        }
    }
    [SerializeField] private float radius;

    [SerializeField] private State StartState;
    [SerializeField] private State AmmoFindState;
    [SerializeField] private State EnemyShootingState;
    [SerializeField] private State WalkToWinZoneState;
    [SerializeField] private State HealthFindState;

    [Header("Actual state")]
    [SerializeField] private State currentState;

    private float distance = 0f;
    private ShootComponent shootComponent;
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
    private void Update()
    {
        if (!currentState.IsFinished)
        {
            currentState.Run();
        }
        else if (shootComponent.Ammo <= 0)
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

    }


    public void SetState(State state)
    {
        currentState = Instantiate(state);
        currentState.unit = this;
        currentState.Init();
    }
    private void SetAllComponents()
    {
        player = FindObjectOfType<PlayerData>();
        tank = GetComponent<Tank>();
        winZona = GameObject.FindGameObjectWithTag(winZonaTag);
        tank.Tower._towerTankData = Test.TowerTankData;
        tank.Tower.TryGetComponent<ShootComponent>(out shootComponent);
        meshAgent = GetComponent<NavMeshAgent>();
        _collider = GetComponent<Collider>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == tagForEnemy)
        {
            Debug.Log("Collis");
            currentState.Stop();
            SetState(EnemyShootingState);
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == tagForEnemy)//other.gameObject.tag == "Player"
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
            Debug.Log("CollisExit");
            tank.Tower.transform.Rotate(0f, 0f, 0f);
            currentState.Stop();
            SetState(WalkToWinZoneState);
        }
    }

}
