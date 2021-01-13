using UnityEngine;

public class Ammo : MonoBehaviour, IInteractable
{
    private int ammoAddCount = 5;
    public void Interact(Tank tank)
    {
        tank.Tower.GetComponent<ShootComponent>().AddAmmo(ammoAddCount);
        if(tank.TryGetComponent<UnitBehavior>(out UnitBehavior unit))
        {
            unit.StopState();
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }
}
