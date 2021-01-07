using UnityEngine;

public class Tower : MonoBehaviour
{

    public TowerTankData _towerTankData { get; set; }
    private MeshFilter _mesh;

    private void Start()
    {
        _mesh = GetComponent<MeshFilter>();
        SetTowerTankData(Test.TowerTankData);
    }

    public void SetTowerTankData(TowerTankData towerTankData)
    {
        _towerTankData = towerTankData;
        _mesh.mesh = _towerTankData.GetMesh();
    }
}
