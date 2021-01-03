using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private static TowerTankData tankData;

    public static TowerTankData TowerTankData
    {
        get
        {
            return tankData;
        }
        set
        {
            tankData = value;
        }
    }


    [SerializeField] private TowerTankData _tankData;


    private void Awake()
    {
        TowerTankData = _tankData;
        Debug.Log(TowerTankData.GetSpeed());
    }
}
