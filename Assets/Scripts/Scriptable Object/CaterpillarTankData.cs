using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New CaterpillarTankData", menuName = "CaterpillarTankData", order = 51)]
public class CaterpillarTankData : ScriptableObject
{
    [SerializeField] private float _speed;

    public float GetSpeed()
    {
        return _speed;
    }
}
