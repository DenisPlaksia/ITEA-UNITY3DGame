using UnityEngine;

[CreateAssetMenu(fileName = "New TowerTankData", menuName = "TowerTankData", order = 51)]
public class TowerTankData : ScriptableObject
{
    [SerializeField] private float speed;
    [SerializeField] private int ammo;
    [SerializeField] private float timeBetweenAtack;
    [SerializeField] private Mesh _towerMesh;

    public Mesh GetMesh()
    {
        return _towerMesh;
    }
    public float GetSpeed()
    {
        return speed;
    }


    public int GetAmmo()
    {
        return ammo;
    }

    public float GetTimeBetweenAtack()
    {
        return timeBetweenAtack;
    }
}
