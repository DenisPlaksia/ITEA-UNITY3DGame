using UnityEngine;

public class HeartAdd : MonoBehaviour, IInteractable
{
    public void Interact(Tank tank)
    {
        int rand = Random.Range(50, 81);
        tank.AddHealth(rand);
        if (tank.TryGetComponent<UnitBehavior>(out UnitBehavior unit))
        {
            unit.StopState();
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
