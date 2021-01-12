using UnityEngine;

[CreateAssetMenu]
public class WalkToWinZoneState : State
{
    private Transform _winZona;
    public State EnemyShootState;
    private float _maxDistance = 1f;
    private RaycastHit _hit;
    public override void Init()
    {

        _winZona = unit.winZona.transform;
    }
    public override void Run()
    {
        if (IsFinished)
        {
            return;
        }
        else
        {
            MoveToZona();
        }
    }

    public override void Stop()
    {
        IsFinished = true;
    }

    private void MoveToZona()
    {
        unit.MeshAgent.SetDestination(_winZona.position);
    }
}
