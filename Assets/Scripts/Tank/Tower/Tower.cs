using UnityEngine;

public class Tower : MonoBehaviour
{

    [SerializeField] private TowerTankData _towerTankData;
    [SerializeField] private TowerMoveComponent moveComponent;
    [SerializeField] private ShootComponent shootComponent;
    private MeshFilter _mesh;

    private void Start()
    {
        shootComponent = GetComponent<ShootComponent>();
        moveComponent = GetComponent<TowerMoveComponent>();
        _mesh = GetComponent<MeshFilter>();
        SetTowerTankData(Test.TowerTankData);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            shootComponent?.Shoot();
        }
    }



    public void SetTowerTankData(TowerTankData towerTankData)
    {
        _towerTankData = towerTankData;
        _mesh.mesh = _towerTankData.GetMesh();
        if (moveComponent != null && shootComponent != null)
        {
            moveComponent.Speed = _towerTankData.GetSpeed();
            shootComponent.TimeBetweenAtack = _towerTankData.GetTimeBetweenAtack();
            shootComponent.Ammo = _towerTankData.GetAmmo();
        }
    }


}
