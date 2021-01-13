using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private static TowerTankData tankData;
    private static CaterpillarTankData caterpillar;
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

    public static CaterpillarTankData CaterpillarTankData
    {
        get
        {
            return caterpillar;
        }
        set
        {
            caterpillar = value;
        }
    }


    [SerializeField] private TowerTankData _tankData;
    [SerializeField] private CaterpillarTankData _caterpillarData;

    private void Awake()
    {
        TowerTankData = _tankData;
        CaterpillarTankData = _caterpillarData;
    }
}
