using UnityEngine;

[CreateAssetMenu]
public class HealthFindState : State
{
    private Transform _health;
    public State NonAmmmoState;
    public override void Init()
    {
        var health = GameObject.FindGameObjectsWithTag("Health");

        if (health.Length == 0)
        {
            unit.SetState(NonAmmmoState);
            return;
        }

        _health = health[Random.Range(0, health.Length)].transform;
    }
    public override void Run()
    {
        if (IsFinished)
        {
            return;
        }
        else
        {
            MoveToAmmo();
        }

    }

    public override void Stop()
    {
        IsFinished = true;
    }

    private void MoveToAmmo()
    {
        unit.MeshAgent.SetDestination(_health.position);
        IsFinished = true;
    }
}
