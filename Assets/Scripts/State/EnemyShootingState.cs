using UnityEngine;

[CreateAssetMenu]
public class EnemyShootingState : State
{
    public float target;
    public State AmmoFindState;
    public State HealthFindState;
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
            if (unit.ShootComponent.Ammo <= 2)
            {
                IsFinished = true;
                unit.SetState(AmmoFindState);
            }
            else if (unit.Tank.GetHealth() <= 50)
            {
                IsFinished = true;
                unit.SetState(HealthFindState);
            }

            unit.ShootComponent.Shoot();
        }
    }

    public override void Stop()
    {
        IsFinished = true;
    }
}
