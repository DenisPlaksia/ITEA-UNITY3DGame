using UnityEngine;

public class Caterpillar : MonoBehaviour
{
    [SerializeField] private CaterpillarTankData _caterpillarData;
    [SerializeField] private CaterpillarMoveComponent moveComponent;
    private void Start()
    {
        moveComponent = GetComponent<CaterpillarMoveComponent>();
        if (moveComponent != null)
        {
            moveComponent.Speed = _caterpillarData.GetSpeed();
            Debug.Log(moveComponent.Speed);

        }
    }
    public void SetCaterpillarTankData(CaterpillarTankData caterpillarTankData)
    {
        _caterpillarData = caterpillarTankData;
    }
}
