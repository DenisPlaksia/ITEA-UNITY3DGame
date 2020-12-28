using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caterpillar : MonoBehaviour
{
    [SerializeField] private CaterpillarTankData caterpillarData;

    public void Moving(Vector3 direction)
    {
        transform.parent.transform.Translate(direction * caterpillarData.GetSpeed() * Time.deltaTime);
    }

    public void Rotation(float direction)
    {
        transform.parent.transform.Rotate(Vector3.up * direction);
    }
}
