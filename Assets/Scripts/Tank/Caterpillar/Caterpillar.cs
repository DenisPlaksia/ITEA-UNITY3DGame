using UnityEngine;

public class Caterpillar : MonoBehaviour
{
    public CaterpillarTankData CaterpillarData { get; set; }

    private void Start()
    {
        SetCaterpillarTankData(Test.CaterpillarTankData);
    }

    public void SetCaterpillarTankData(CaterpillarTankData caterpillarTankData)
    {
        CaterpillarData = caterpillarTankData;
    }
}
