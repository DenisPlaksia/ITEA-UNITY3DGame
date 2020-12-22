using UnityEngine;

[CreateAssetMenu(fileName = "New TowerTankData", menuName = "TowerTankData", order = 51)]
public class TowerTankData : ScriptableObject
{
    [SerializeField] private float speed;
    [SerializeField] private float ammo;

    public float GetSpeed()
    {
        return speed;
    }


    public float GetAmmo()
    {
        return ammo;
    }
}
