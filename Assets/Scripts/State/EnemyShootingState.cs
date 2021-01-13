using UnityEngine;

[CreateAssetMenu]
public class EnemyShootingState : State
{
    public float target;
    public State AmmoFindState;

    public override void Init()
    {
        target = unit.ShootAngle;
        unit.MeshAgent.SetDestination(unit.transform.position);
    }

    public override void Run()
    {
        if (IsFinished)
        {

            return;
        }
        else
        {
            if (unit.ShootComponent.Ammo == 0)
            {
                IsFinished = true;
                unit.SetState(AmmoFindState);
            }

            unit.ShootComponent.Shoot();
        }
    }

    public override void Stop()
    {
        IsFinished = true;
    }
}
